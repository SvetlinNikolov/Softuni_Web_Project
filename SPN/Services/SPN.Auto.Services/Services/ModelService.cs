using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.ViewModels.Model;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class ModelService : BaseService, IModelService
    {
        public ModelService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task<IEnumerable<ModelConciseViewModel>> GetAllModels()
        {

            //var carModels = mapper
            //      .Map<IEnumerable<ModelConciseViewModel>>(models); //Map

            var models = await this.dbContext
                   .Models
                   .Select(m => new ModelConciseViewModel { Name = m.Name })
                   .ToListAsync();

            return models;
        }
    }
}
