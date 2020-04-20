using AutoMapper;
using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Services.Services.Helpers;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Common.Cloudinary;
using SPN.Data.Models.Auto;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
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
            var ImageHelper = new ImagesHelper();

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
            automobile.Images = await ImageHelper.SetAutomobileImages(model, this.cloudinary);

            //TODO add images
            await dbContext.Automobiles.AddAsync(automobile);
            await dbContext.SaveChangesAsync();

        }
    }
}
