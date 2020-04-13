using System.Reflection;

namespace SPN.Data.Common.Constants
{

    public static class GlobalConstants
    {
        public static string CurrentDirectory = Assembly.GetExecutingAssembly().Location;
        public static string CategoriesJsonLocation = CurrentDirectory + @"../../../../../../../Data/SPN.Data/Seeding/Datasets/Categories.json";
        public static string UsersJsonLocation = CurrentDirectory + @"../../../../../../../Data/SPN.Data/Seeding/Datasets/Users.json";
        public static string ContestCategoriesJsonLocation = CurrentDirectory + @"../../../../../../../Data/SPN.Data/Seeding/Datasets/ContestCategories.json";
        public static string CarDbLocation = CurrentDirectory + @"../../../../../../../Data/SPN.Data/Seeding/Datasets/CarDb.txt";

        public static string CarAutoDbLocation = CurrentDirectory + @"../../../../../../../Data/SPN.Data/Seeding/Datasets/Auto.json";
    }
}
