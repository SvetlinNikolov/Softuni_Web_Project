﻿namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.ViewModels.ForumInputModels.Contracts;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IPostService
    {
        Post GetPostById(int id);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByCategory(int searchQuery);
        Task<int> CreatePost(IPostInputModel model, User user, int categoryId);
        Task DeletePost(int id);
        Task EditPost(int id);
        int GetTotalPostsCount();

    }
}
