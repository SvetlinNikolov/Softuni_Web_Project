﻿using AutoMapper;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Services.Services.Helpers;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Data.Common.Constants;
using SPN.Data.Models.Auto;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    [Authorize]
    public class AutoService : BaseService, IAutoService
    {
        private readonly IUserService userService;
        private readonly Cloudinary cloudinary;
        private readonly ImagesHelper imagesHelper;

        public AutoService(IMapper mapper, SPNDbContext dbContext, IUserService userService, Cloudinary cloudinary, ImagesHelper imagesHelper)
            : base(mapper, dbContext)
        {
            this.userService = userService;
            this.cloudinary = cloudinary;
            this.imagesHelper = imagesHelper;
        }


        public async Task CreateAutomobileAsync(MainCreateInputModel model)
        {
            var makeId = await this.dbContext.Makes //TODO maybe add another method that uses select list item so you dont have to use string search
                .Where(x => x.Name == model.PrimaryProperties.Make)
                .Select(x => x.Id)
                .FirstOrDefaultAsync();

            var modelId = await this.dbContext.Models
               .Where(x => x.Name == model.PrimaryProperties.Model)
               .Select(x => x.Id)
               .FirstOrDefaultAsync();

            Automobile automobile = this.mapper.Map<Automobile>(model);

            automobile.MakeId = makeId;
            automobile.ModelId = modelId;
            automobile.CreatedOn = DateTime.UtcNow;
            automobile.UserId = this.userService.GetLoggedInUserId();
            automobile.Images = await imagesHelper.SetAutomobileImages(model.Images, this.cloudinary);

            //TODO add images
            await dbContext.Automobiles.AddAsync(automobile);
            await dbContext.SaveChangesAsync();

        }

        public async Task EditAutomobileAsync(int id, EditAutomobileInputModel inputModel)
        {
            var automobileToEdit = await this.GetAutomobileByIdAsync(id);

            if (!await UserOwnsAutomobileAsync(automobileToEdit))
            {
                throw new UnauthorizedAccessException(ModelConstants.Unauthorized);
            }

            Automobile automobile = this.mapper.Map<Automobile>(inputModel);

            automobileToEdit.Make = await this.dbContext.Makes
                .Where(x => x.Name == inputModel.PrimaryProperties.Make)
                .FirstOrDefaultAsync();

            automobileToEdit.Model = await this.dbContext.Models
               .Where(x => x.Name == inputModel.PrimaryProperties.Model)
               .FirstOrDefaultAsync();

            automobileToEdit.Title = inputModel.Title;
            automobileToEdit.Comment = inputModel.Comment;
            automobile.ModifiedOn = DateTime.UtcNow;

            automobileToEdit.PrimaryProperties = automobile.PrimaryProperties;
            automobileToEdit.Safety = automobile.Safety;
            automobileToEdit.Interiors = automobile.Interiors;
            automobileToEdit.InteriorMaterials = automobile.InteriorMaterials;
            automobileToEdit.Suspensions = automobile.Suspensions;
            automobileToEdit.ExtraFeatures = automobile.ExtraFeatures;
            automobileToEdit.SpecializedFeatures = automobile.SpecializedFeatures;
            automobileToEdit.Images = await imagesHelper.SetAutomobileImages(inputModel.Images, this.cloudinary);


            this.dbContext.Update(automobileToEdit);
            await this.dbContext.SaveChangesAsync();
        }


        public async Task<EditAutomobileInputModel> GetAutomobileEditInputModelAsync(int id)
        {
            Automobile automobile = await this.GetAutomobileByIdAsync(id);

            if (!await UserOwnsAutomobileAsync(automobile))
            {
                throw new UnauthorizedAccessException(ModelConstants.Unauthorized);
            }

            EditAutomobileInputModel viewModel = this.mapper.Map<EditAutomobileInputModel>(automobile);

            return viewModel;
        }


        public async Task<AutomobileViewModel> GetAutomobileViewModelByIdAsync(int id)
        {
            Automobile automobile = await this.GetAutomobileByIdAsync(id);

            AutomobileViewModel viewModel = this.mapper.Map<AutomobileViewModel>(automobile);

            return viewModel;
        }

        public async Task<Automobile> GetAutomobileByIdAsync(int id)
        {
            Automobile automobile = await this.dbContext.Automobiles
               .Where(x => x.Id == id)
               .Where(x => x.IsDeleted == false)
               .Include(x => x.User)
               .Include(x => x.Make)
               .Include(x => x.Model)
               .Include(x => x.PrimaryProperties)
               .Include(x => x.Safety)
               .Include(x => x.InteriorMaterials)
               .Include(x => x.Suspensions)
               .Include(x => x.ExtraFeatures)
               .Include(x => x.Interiors)
               .Include(x => x.Images)
               .FirstOrDefaultAsync();

            return automobile;
        }

        public async Task DeleteAutomobileAsync(int id)
        {
            var automobile = await this.GetAutomobileByIdAsync(id);

            if (!await UserOwnsAutomobileAsync(automobile))
            {
                throw new UnauthorizedAccessException(ModelConstants.Unauthorized);
            }

            automobile.IsDeleted = true;
            automobile.ModifiedOn = DateTime.UtcNow;

            this.dbContext.Update(automobile);
            await this.dbContext.SaveChangesAsync();

        }

        public async Task<DeleteInputModel> GetAutomobileDeleteInputModelAsync(int id)
        {
            var automobile = await this.dbContext.Automobiles
                .FirstOrDefaultAsync(x => x.Id == id);

            if (automobile == null)
            {
                throw new ArgumentNullException(ModelConstants.AutomobileNull);
            }

            if (!await UserOwnsAutomobileAsync(automobile))
            {
                throw new UnauthorizedAccessException(ModelConstants.Unauthorized);
            }

            var inputModel = new DeleteInputModel { Id = automobile.Id, Title = automobile.Title };

            return inputModel;

        }

        private async Task<bool> UserOwnsAutomobileAsync(Automobile automobile)
        {
            var user = await this.userService.GetLoggedInUserAsync();

            if (user == null)
            {
                throw new ArgumentNullException(ModelConstants.UserNotLoggedIn);
            }

            if (user.Automobiles == null ||
                user.Automobiles.Count() == 0 ||
                user.Automobiles.Any(x => x.UserId != automobile.UserId))
            {
                return false;
            }

            return true;
        }

    }
}
