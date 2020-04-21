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
        public async Task<Images> SetAutomobileImages(ImagesInputModel model, Cloudinary cloudinary)
        {
            Images images = new Images();

            if (model.ImageUrl1 != null)
            {
                images.ImageUrl1 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl1, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl2 != null)
            {
                images.ImageUrl2 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl2, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl3 != null)
            {
                images.ImageUrl3 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl3, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl4 != null)
            {
                images.ImageUrl4 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl4, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl5 != null)
            {
                images.ImageUrl5 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl5, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl6 != null)
            {
                images.ImageUrl6 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl6, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl7 != null)
            {
                images.ImageUrl7 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl7, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl8 != null)
            {
                images.ImageUrl8 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl8, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl9 != null)
            {
                images.ImageUrl9 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl9, Guid.NewGuid().ToString());
            }
            if (model.ImageUrl10 != null)
            {
                images.ImageUrl10 = await ApplicationCloudinary.UploadImage(cloudinary, model.ImageUrl10, Guid.NewGuid().ToString());
            }

            return images;
        }
    }
}
