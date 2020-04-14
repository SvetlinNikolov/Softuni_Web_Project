using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class ImagesInputModel
    {
        [DataType(DataType.Upload)]
        public IFormFile ImageUrl1 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl2 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl3 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl4 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl5 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl6 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl7 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl8 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl9 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageUrl10 { get; set; }
    }
}
