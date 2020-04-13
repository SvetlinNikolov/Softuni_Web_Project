namespace SPN.Forum.Data.Seeding
{
    using Microsoft.AspNetCore.Identity;
    using Newtonsoft.Json;
    using SPN.Data.Common.Constants;
    using SPN.Forum.Data;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    public class SPNUserRoleSeeder : ISeeder
    {
        private readonly SPNDbContext dbContext;
        private string jsonData = File.ReadAllText(GlobalConstants.UsersJsonLocation);


        public SPNUserRoleSeeder(SPNDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Seed()
        {
            if (!dbContext.Roles.Any())
            {
                var userRoles = JsonConvert.DeserializeObject<IdentityRole[]>(jsonData);

                await dbContext.Roles.AddRangeAsync(userRoles);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}

