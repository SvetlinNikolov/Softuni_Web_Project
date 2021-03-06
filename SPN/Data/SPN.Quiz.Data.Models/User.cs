﻿
using Microsoft.AspNetCore.Identity;
using SPN.Data.Common.Contracts;
using SPN.Forum.Data.Models;
using SPN.Quiz.Data.Models.Enums;
using System;
using System.Collections.Generic;

namespace SPN.Quiz.Data.Models
{


    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public User()
        {
            PostLikes = new HashSet<PostLike>();
            ReplyLikes = new HashSet<ReplyLike>();
            QuoteLikes = new HashSet<QuoteLike>();
            Replies = new HashSet<Reply>();
            Posts = new HashSet<Post>();
            Quotes = new HashSet<Quote>();

            Contests = new HashSet<Contest>();
            ContestsSolutions = new HashSet<ContestSolution>();
        }
        public Gender Gender { get; set; }

        public string Description { get; set; }

        public string ProfileImage { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<PostLike> PostLikes { get; set; }

        public virtual ICollection<ReplyLike> ReplyLikes { get; set; }

        public virtual ICollection<QuoteLike> QuoteLikes { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Quote> Quotes { get; set; }

        public virtual ICollection<Contest> Contests { get; set; } //Contests Created

        public virtual ICollection<ContestSolution> ContestsSolutions { get; set; } //Solutions submited



    }
}
