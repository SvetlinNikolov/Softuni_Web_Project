namespace SPN.Data.Common.Constants
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

        public const string PostContentLengthError = "Description must be between {2} and {1} symbols";

        //----------------------------------------------------
        // User
        public const int UsernameMinLength = 3;

        public const int UsernameMaxLength = 20;

        public const int PasswordMinLength = 8;

        public const int PasswordMaxLength = 30;

        public const string UsernameLenghtError = "Name must be between {2} and {1} symbols";

        public const string PasswordLenghtError = "Password must be between {2} and {1} symbols";
    }
}
