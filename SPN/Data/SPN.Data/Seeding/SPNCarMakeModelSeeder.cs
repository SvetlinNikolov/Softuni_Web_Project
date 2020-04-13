//namespace SPN.Forum.Data.Seeding
//{
//    using Microsoft.EntityFrameworkCore;
//    using SPN.Auto.Data.Models;
//    using SPN.Data.Common.Constants;
//    using System;
//    using System.IO;
//    using System.Linq;
//    using System.Threading.Tasks;
//    public class SPNCarMakeModelSeeder : ISeeder
//    {
//        private readonly SPNDbContext dbContext;
//        private string carData = File.ReadAllText(GlobalConstants.CarDbLocation);
//        public SPNCarMakeModelSeeder(SPNDbContext dbContext)

//        {
//            this.dbContext = dbContext;
//        }

//        public async Task Seed()
//        {
//            if (this.dbContext.Makes.Any()) return;

//            var cars = carData.Split(",");

//            var makes = this.dbContext.Makes;
//            var models = this.dbContext.Models;

//            for (int i = 0; i < cars.Length - 1; i += 2)
//            {
//                string carMake = cars[i];
//                string carModel = cars[i + 1];

//                Make makeExists = await makes.Where(x => x.Name == carMake).FirstOrDefaultAsync();
//                Model modelExists = await models.Where(x => x.Name == carModel).FirstOrDefaultAsync();

//                var makeToAdd = new Make();
//                var modelToAdd = new Model();

//                if (makeExists == null)
//                {
//                    makeToAdd.Name = carMake;
//                    makeToAdd.CreatedOn = DateTime.UtcNow;

//                    await this.dbContext.Makes.AddAsync(makeToAdd);
//                    await this.dbContext.SaveChangesAsync();

//                    modelToAdd.Name = carModel;
//                    modelToAdd.CreatedOn = DateTime.UtcNow;
//                    modelToAdd.MakeId = makeToAdd.Id;

//                    await makes.AddAsync(makeToAdd);
//                    await models.AddAsync(modelToAdd);
//                }
//                else
//                {
//                    if (modelExists == null)
//                    {
//                        modelToAdd.Name = carModel;
//                        modelToAdd.CreatedOn = DateTime.UtcNow;

//                        await models.AddAsync(modelToAdd);
//                    }
//                }


//            }
//            await this.dbContext.Makes.AddRangeAsync(makes);
//            await this.dbContext.SaveChangesAsync();

//        }

//    }
//}
