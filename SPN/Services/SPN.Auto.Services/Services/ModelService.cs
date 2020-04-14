using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.ViewModels.Model;
using SPN.Data.Models.Auto;
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

        public async Task<ModelConciseViewModel> GetModelById(int Id)
        {
            Model model = await this.dbContext.Models.FirstOrDefaultAsync(x => x.Id == Id);

            ModelConciseViewModel viewModel = this.mapper.Map<ModelConciseViewModel>(model);

            return viewModel;
        }

        public async Task<ModelConciseViewModel> GetModelByName(string name)
        {
            Model model = await this.dbContext.Models.FirstOrDefaultAsync(x => x.Name == name);

            ModelConciseViewModel viewModel = this.mapper.Map<ModelConciseViewModel>(model);

            return viewModel;
        }
    }
}
