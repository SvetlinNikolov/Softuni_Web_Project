namespace SPN.Data.Seeding
{
    using Newtonsoft.Json;
    using SPN.Data.Common.Constants;
    using SPN.Data.Models.Quiz;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SPNContestCategorySeeder : ISeeder
    {
        private readonly SPNDbContext dbContext;
        private string jsonData = File.ReadAllText(GlobalConstants.ContestCategoriesJsonLocation);
        public SPNContestCategorySeeder(SPNDbContext dbContext)

        {
            this.dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (!this.dbContext.Categories.Any())
            {
                var contestCategories = JsonConvert.DeserializeObject<ContestCategory[]>(jsonData);
                await dbContext.ContestCategories.AddRangeAsync(contestCategories);
            }
        }
    }
}
