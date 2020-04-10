using Newtonsoft.Json;
using SPN.Auto.Data.Models;
using SPN.Data.Common.Constants;
using SPN.Forum.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Forum.Data.Seeding
{
    public class SPNCarMakeModelSeeder : ISeeder
    {
        private readonly SPNDbContext dbContext;
        private string carData = File.ReadAllText(GlobalConstants.CarDbLocation);
        public SPNCarMakeModelSeeder(SPNDbContext dbContext)

        {
            this.dbContext = dbContext;
        }

        public async Task Seed()
        {
            var cars = carData.Split(",");

            //List<Make> makes = new List<Make>();
            //List<Model> models = new List<Model>();
            //List<MakeModel> makesModels = new List<MakeModel>();

            for (int i = 0; i < cars.Length - 1; i += 2)
            {
                var carMake = cars[i];
                var carModel = cars[i + 1];

                var modeleeee = this.dbContext.Models.Where(x => x.Name == carModel).FirstOrDefault();

                var makeee = this.dbContext.Makes.Where(x => x.Name == carMake).FirstOrDefault();

                if (makeee == null)
                {
                    Make make = new Make
                    {
                        Name = carMake,
                        CreatedOn = DateTime.UtcNow
                    };
                    this.dbContext.Makes.Add(make);
                    this.dbContext.SaveChanges();


                    if (modeleeee == null)
                    {
                        var model = new Model
                        {
                            Name = carModel,
                            CreatedOn = DateTime.UtcNow
                        };

                        this.dbContext.Models.Add(model);
                        this.dbContext.SaveChanges();

                        this.dbContext.MakesModels.Add(new MakeModel { MakeId = make.Id, ModelId = model.Id });
                        this.dbContext.SaveChanges();

                    }

                }
                else
                {
                    if (modeleeee == null)
                    {
                        var model = new Model
                        {
                            Name = carModel,
                            CreatedOn = DateTime.UtcNow
                        };

                        this.dbContext.Models.Add(model);
                        this.dbContext.SaveChanges();

                        this.dbContext.MakesModels.Add(new MakeModel { MakeId = makeee.Id, ModelId = model.Id });
                        this.dbContext.SaveChanges();

                    }
                }
            }

          ;
        }
    }
}
