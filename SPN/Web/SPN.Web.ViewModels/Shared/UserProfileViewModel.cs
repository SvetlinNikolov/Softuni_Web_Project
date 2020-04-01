using System;

namespace SPN.Forum.Web.ViewModels.Shared
{
    public class UserProfileViewModel
    {
        public string Id { get; set; } //User Id

        public string Username { get; set; }

        public DateTime MemberSince { get; set; }

        public string Email { get; set; }

        public string ProfileImage { get; set; }


    }
}
