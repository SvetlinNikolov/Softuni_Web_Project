using SPN.Auto.Web.ViewModels.Search;
using System;
using System.Collections.Generic;

namespace SPN.Forum.Web.ViewModels.Shared
{
    public class UserProfileViewModel
    {
        public string Id { get; set; } //User Id

        public string Username { get; set; }

        public DateTime MemberSince { get; set; }

        public string Email { get; set; }

        public string ProfileImage { get; set; }

        public SearchResultListingViewModel Automobiles { get; set; }

    }
}
