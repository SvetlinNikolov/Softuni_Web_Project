using AutoMapper;
using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Common.Cloudinary;
using SPN.Data.Models.Auto;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class AutoService : BaseService, IAutoService
    {
        private readonly IUserService userService;
        private readonly Cloudinary cloudinary;

        public AutoService(IMapper mapper, SPNDbContext dbContext, IUserService userService, Cloudinary cloudinary)
            : base(mapper, dbContext)
        {
            this.userService = userService;
            this.cloudinary = cloudinary;
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
            automobile.UserId = this.userService.GetLoggedInUserAsync().Result.Id; //TODO create a get user Id in userService


            var ImgUrl1 = await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl1, model.Images.ImageUrl1?.ToString());
            Images images = new Images { ImageUrl1 = ImgUrl1 };

            automobile.Images = images;
            //TODO add images

            //Images images = new Images
            //{
            //    CreatedOn = DateTime.UtcNow,
            //    ImageUrl1 = model.Images?.ImageUrl1?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl1, model.Images.ImageUrl1?.ToString()),
            //    ImageUrl2 = model.Images?.ImageUrl2?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl2, model.Images.ImageUrl2?.ToString()),
            //    ImageUrl3 = model.Images?.ImageUrl3?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl3, model.Images.ImageUrl3?.ToString()),
            //    ImageUrl4 = model.Images?.ImageUrl4?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl4, model.Images.ImageUrl4?.ToString()),
            //    ImageUrl5 = model.Images?.ImageUrl5?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl5, model.Images.ImageUrl5?.ToString()),
            //    ImageUrl6 = model.Images?.ImageUrl6?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl6, model.Images.ImageUrl6?.ToString()),
            //    ImageUrl7 = model.Images?.ImageUrl7?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl7, model.Images.ImageUrl7?.ToString()),
            //    ImageUrl8 = model.Images?.ImageUrl8?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl8, model.Images.ImageUrl8?.ToString()),
            //    ImageUrl9 = model.Images?.ImageUrl9?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl9, model.Images.ImageUrl9?.ToString()),
            //    ImageUrl10 = model.Images?.ImageUrl10?.ToString() ?? await ApplicationCloudinary.UploadImage(this.cloudinary, model.Images.ImageUrl10, model.Images.ImageUrl10?.ToString())
            //};

            await dbContext.Automobiles.AddAsync(automobile);
            await dbContext.SaveChangesAsync();

        }
    }
}
