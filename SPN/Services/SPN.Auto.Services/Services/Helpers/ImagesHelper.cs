using CloudinaryDotNet;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Common.Cloudinary;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services.Helpers
{
    public class ImagesHelper
    {
        public async Task<Images> SetAutomobileImages(MainCreateInputModel model, Cloudinary cloudinary)
        {
            Images images = new Images();

            if (model.Images.ImageUrl1 != null)
            {
                images.ImageUrl1 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl1, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl2 != null)
            {
                images.ImageUrl2 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl2, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl3 != null)
            {
                images.ImageUrl3 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl3, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl4 != null)
            {
                images.ImageUrl4 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl4, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl5 != null)
            {
                images.ImageUrl5 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl5, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl6 != null)
            {
                images.ImageUrl6 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl6, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl7 != null)
            {
                images.ImageUrl7 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl7, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl8 != null)
            {
                images.ImageUrl8 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl8, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl9 != null)
            {
                images.ImageUrl9 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl9, Guid.NewGuid().ToString());
            }
            if (model.Images.ImageUrl10 != null)
            {
                images.ImageUrl10 = await ApplicationCloudinary.UploadImage(cloudinary, model.Images.ImageUrl10, Guid.NewGuid().ToString());
            }

            return images;
        }
    }
}
