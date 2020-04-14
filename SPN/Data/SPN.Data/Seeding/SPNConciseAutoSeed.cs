using Newtonsoft.Json;
using SPN.Data.Common.Constants;
using SPN.Data.Models.Auto;
using SPN.Data.Seeding.DTO;
using SPN.Forum.Data;
using SPN.Forum.Data.Seeding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Data.Seeding
{
    public class SPNConciseAutoSeed : ISeeder
    {
        private readonly SPNDbContext dbContext;
        private string jsonData = File.ReadAllText(GlobalConstants.CarAutoDbLocation);

        public SPNConciseAutoSeed(SPNDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Seed()
        {
            if (!dbContext.Makes.Any())
            {
                var automobiles = JsonConvert.DeserializeObject<ImportMakeModelDto[]>(jsonData);

                var models = new List<Model>();

                foreach (var makeModelDTO in automobiles)
                {
                    var make = new Make
                    {
                        Name = makeModelDTO.Make,
                        CreatedOn = DateTime.UtcNow
                    };

                    await this.dbContext.Makes.AddAsync(make);
                    await this.dbContext.SaveChangesAsync();

                    foreach (var modelDto in makeModelDTO.Models)
                    {
                  
                        var model = new Model
                        {
                            Name = modelDto,
                            CreatedOn = DateTime.UtcNow,
                            Make = make
                        };
                        await this.dbContext.Models.AddAsync(model);
                        await this.dbContext.SaveChangesAsync();

                        //models.Add(model);
                        
                    }
                    

                    //await this.dbContext.Models.AddRangeAsync(models);
                    //await this.dbContext.SaveChangesAsync();

                //TODO make this addrange for models 
                }
            }
        }
    }
}
