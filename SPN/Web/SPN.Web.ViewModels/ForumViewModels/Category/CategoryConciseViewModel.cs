﻿
namespace SPN.Web.ViewModels.ForumViewModels.CategoryViewModels
{
    using AutoMapper;
    using SPN.Data.Models.Forum;

    public class CategoryConciseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }    
        //public int LikesCount { get; set; }         //TODO IMPLEMENT HOW THE LIKES SHOULD WORK
  
    }
}