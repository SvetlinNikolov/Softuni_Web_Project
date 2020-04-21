namespace SPN.Services.Shared
{
    using CloudinaryDotNet;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SPN.Auto.Web.InputModels.User;
    using SPN.Auto.Web.ViewModels.Search;
    using SPN.Data.Common.Cloudinary;
    using SPN.Data.Models.Shared.Identity;
    using SPN.Forum.Data;
    using SPN.Forum.Web.ViewModels.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;


    public class UserService : IUserService
    {
        private readonly SPNDbContext context;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<User> userManager;
        private readonly SPNDbContext dbContext;
        private readonly Cloudinary cloudinary;

        public UserService(SPNDbContext context,
                IHttpContextAccessor httpContextAccessor,
                UserManager<User> userManager,
                SPNDbContext dbContext,
                Cloudinary cloudinary
                )
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.dbContext = dbContext;
            this.cloudinary = cloudinary;
        }


        public async Task<User> GetLoggedInUserAsync()
        {
            var userId = httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier)
                .Value;

            var user = await context.Users
                .Include(x => x.Automobiles)
                .SingleOrDefaultAsync(u => u.Id == userId);

            return user;
        }

        public async Task<User> GetUserById(string id)
        {
            var user = await dbContext.Users
                 .Where(x => x.IsDeleted == false)
                 .Where(x => x.Id == id)
                 .Include(x => x.Automobiles)
                 .ThenInclude(x => x.Model)
                 .ThenInclude(x => x.Make)
                 .Include(x => x.Automobiles)
                 .ThenInclude(x => x.PrimaryProperties)
                 .Include(x => x.Automobiles)
                 .ThenInclude(x => x.Images)
                 .SingleOrDefaultAsync();


            return user;
        }

        public async Task<IEnumerable<User>> GetUsersByRoleAsync(string role)
        {
            var usersInRole = await userManager.GetUsersInRoleAsync(role);

            return await dbContext
                .Users
                .Where(u => usersInRole.Any(x => x.Id == u.Id))
                .ToListAsync();
        }

        public async Task<bool> RemoveUserFromToRoleAsync(string userId, string role)
        {
            var user = await GetUserById(userId);
            if (user == null)
            {
                return false;
            }

            await userManager.RemoveFromRoleAsync(user, role);
            return true;
        }

        public async Task<bool> AddUserToRoleAsync(string userId, string role)
        {
            var user = await GetUserById(userId);

            if (user == null)
            {
                return false;
            }

            await userManager.AddToRoleAsync(user, role);
            return true;
        }

        public string GetLoggedInUserId()
        {

            var userId = httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier)
                .Value;

            return userId;
        }

        public async Task<UserProfileViewModel> GetUserViewModelByUserIdAsync(string id)
        {
            var user = await this.GetUserById(id);

            var userProfileModel = new UserProfileViewModel();

            if (user?.Automobiles == null)
            {
                return null;
            }
            var searchResultsConcise = user.Automobiles
                .Select(x => new SearchResultConciseViewModel
                {
                    Id = x.Id,
                    Make = x.Make.Name,
                    Model = x.Model.Name,
                    SellerId = x.UserId,
                    SellerName = x.User.UserName,
                    Title = x.Title,
                    Mileage = x.PrimaryProperties.Mileage,
                    CreatedOn = x.CreatedOn,
                    Year = x.PrimaryProperties.Year,
                    Price = x.PrimaryProperties.Price,
                    ImageUrl = x.Images.ImageUrl1 //TODO imageurl1 shouldnt exist
                })
                .ToList();

            var searchResultsListing = new SearchResultListingViewModel { SearchResults = searchResultsConcise };

            var viewModel = new UserProfileViewModel
            {
                Automobiles = searchResultsListing,
                PhoneNumber = user.PhoneNumber,
                Username = user.UserName,
                MemberSince = user.CreatedOn,
                Email = user.Email,
                Id = user.Id,
                ProfileImage = user.ProfileImage
            }; //TODO MAP

            return viewModel;
        }

        public async Task<string> EditUserProfileAsync(UserEditInputModel model)
        {
            var user = await this.GetLoggedInUserAsync();

            user.PhoneNumber = model.PhoneNumber;
            user.Email = model.Email;
            user.ProfileImage = await ApplicationCloudinary.UploadImage(cloudinary, model.ProfilePicture, Guid.NewGuid().ToString());

            this.dbContext.Update(user);
            await this.dbContext.SaveChangesAsync();

            return user.Id;
        }


    }
}
