﻿namespace SPN.Data.Common.Constants
{

    public class ModelConstants
    {
        //Forum Category

        public const int CategoryTitleMinLength = 5;

        public const int CategoryTitleMaxLength = 20;

        public const int CategoryDescriptionMinLength = 10;

        public const int CategoryDescriptionMaxLength = 200;

        public const string CategoryDescriptionLengthError = "Description must be between {2} and {1} symbols";

        public const string CategoryTitleLengthError = "Title must be between {2} and {1} symbols";

        //----------------------------------------------------
        // Forum Post

        public const int PostTitleMinLength = 10;

        public const int PostTitleMaxLength = 30;

        public const int PostContentMinLength = 10;

        public const int PostContentMaxLength = 200;

        public const string PostTitleLengthError = "Title must be between {2} and {1} symbols";

        public const string PostContentLengthError = "Description must be between {2} and {1} symbols";

        //----------------------------------------------------
        // Forum Reply

        public const int ReplyContentMinLenght = 10;

        public const int ReplyContentMaxLenght = 200;

        public const string ReplyContentLengthError = "Reply must be between {2} and {1} symbols";
        //----------------------------------------------------
        // Forum Quote


        public const int QuoteContentMinLenght = 10;

        public const int QuoteContentMaxLenght = 100;

        public const string QuoteContentLenghtError = "Quote must be between {2} and {1} symbols";

        //----------------------------------------------------
        // User

        public const int UsernameMinLength = 3;

        public const int UsernameMaxLength = 20;

        public const string UsernameLenghtError = "Name must be between {2} and {1} symbols";

        //SearchResultListingViewModel
        public const string SearchTitle = "Showing results for : Make: {2}, Model: {1}";

        public const string Unauthorized = "You are not authorized for this action!";

        public const string AutomobileNull = "Automobile does not exist!";

        public const string UserNotLoggedIn = "You are not logged in!";
    }
}
