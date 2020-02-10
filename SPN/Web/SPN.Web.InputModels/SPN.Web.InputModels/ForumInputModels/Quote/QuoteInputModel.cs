﻿namespace SPN.Web.InputModels.ForumInputModels.Quote
{
    using System;
    public class QuoteInputModel
    {
        
        public int Id { get; set; } 

        public string ReplyAuthorId { get; set; }

        public string ReplyContent { get; set; }         //The reply we are quoting (the actual text)

        public string AuthorId { get; set; }

        public string Content { get; set; }


    }
}
