using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Data.Models;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class AutoService :BaseService, IAutoService
    {
        public AutoService(IMapper mapper, SPNDbContext dbContext) 
            : base(mapper, dbContext)
        {
        }

        public async Task CreateAutomobileAsync(MainCreateInputModel model)
        {
            var makeId = await this.dbContext.Makes //TODO maybe add another method that uses select list item so you dont have to use string search
                .Where(x => x.Name == model.PrimaryProperties.Make)
                .Select(x => x.Id)
                .FirstOrDefaultAsync();

            var modelId = await this.dbContext.Models //TODO maybe add another method that uses select list item so you dont have to use string search
               .Where(x => x.Name == model.PrimaryProperties.Model)
               .Select(x => x.Id)
               .FirstOrDefaultAsync();

            Automobile automobile = this.mapper.Map<Automobile>(model);

            automobile.MakeId = makeId;
            automobile.ModelId = modelId;
            automobile.CreatedOn = DateTime.UtcNow;

            await dbContext.Automobiles.AddAsync(automobile);
            await dbContext.SaveChangesAsync();


        }
    }
}
