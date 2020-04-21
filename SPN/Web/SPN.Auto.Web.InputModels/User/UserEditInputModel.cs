using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.InputModels.User
{
    public class UserEditInputModel
    {
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public IFormFile ProfilePicture { get; set; }


    }
}
