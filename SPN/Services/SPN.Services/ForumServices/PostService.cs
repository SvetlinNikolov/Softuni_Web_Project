﻿namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Post;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    public class PostService : BaseService,IPostService
    {
        public PostService(IMapper mapper, SPNDbContext dbContext) 
            : base(mapper, dbContext)
        {
        }

        public async Task<int> CreatePostAsync(PostInputModel model, User user)
        {
            var postCategory = this.dbContext.Categories
                   .FirstOrDefault(c => c.Id == model.Id);

            var post = new Post
            {
                Title = model.Title,
                Content = model.Content,
                Category = postCategory,
                CategoryId = postCategory.Id,
                Author = user,
                AuthorId = user.Id,
                CreatedOn = DateTime.UtcNow,
            };

            await this.dbContext.Posts.AddAsync(post);
            return await this.dbContext.SaveChangesAsync();

        }
        public Task DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return await this.dbContext
                .Posts
                .Include(p => p.Category)
                .Include(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.PostLikes)
                .FirstOrDefaultAsync(p => p.Id == id);

        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetPostsByCategoryAsync(int id)
        {

            var posts = await this.dbContext
                .Posts
                .Include(p => p.Category)
                .Include(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.PostLikes)
                .Where(p => p.CategoryId == id)
                .ToListAsync();

            return posts;
        }
        public int GetTotalPostsCount()
        {
            return 42069;
        }


    }
}
