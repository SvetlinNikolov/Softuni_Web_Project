﻿namespace SPN.Services.Contracts.Forum
{
    using Microsoft.AspNetCore.Identity;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.ViewModels.ForumInputModels.Contracts;
    using System.Collections.Generic;
 
    using System.Threading.Tasks;

    public interface ICategoryService
    {
        Category GetCategoryByIdWithPosts(int id);
        IEnumerable<Category> GetAllCategories();
        Task<int> CreateCategory(ICategoryInputModel categoryInputModel, User identityUser);
        Task DeleteCategory(int categoryId);
        Task UpdateCategoryTitle(int categoryId, string newTitle);
        Task UpdateCategoryDescription(int categoryId, string newDescription);
        Category GetCategoryById(int id);
    }
}
