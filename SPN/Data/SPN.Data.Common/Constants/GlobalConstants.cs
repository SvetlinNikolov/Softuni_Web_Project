using System.Reflection;

namespace SPN.Data.Common.Constants
{

    public class GlobalConstants
    {
        public static string CurrentDirectory = Assembly.GetExecutingAssembly().Location;
        public static string CategoriesJsonLocation = CurrentDirectory + @"../../../../../../../Data/SPN.Data/Seeding/Datasets/Categories.json";
        public static string UsersJsonLocation = CurrentDirectory + @"../../../../../../../Data/SPN.Data/Seeding/Datasets/Users.json";
    }
}
