using Newtonsoft.Json;
using SPN.Data.Common.Constants;
using SPN.Data.Models.Forum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Forum.Data.Seeding
{
    public class SPNCategorySeeder : ISeeder
    {
        private readonly SPNDbContext dbContext;
        private string jsonData = File.ReadAllText(GlobalConstants.CategoriesJsonLocation);
        public SPNCategorySeeder(SPNDbContext dbContext)

        {
            this.dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (!dbContext.Categories.Any())
            {
                var categories = JsonConvert.DeserializeObject<Category[]>(jsonData);
                await dbContext.Categories.AddRangeAsync(categories);
            }
        }
    }
}
