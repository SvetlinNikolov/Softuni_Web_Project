using SPN.Auto.Web.ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IModelService
    {
        Task<IEnumerable<ModelConciseViewModel>> GetAllModels();

        public Task<ModelConciseViewModel> GetModelById();

        public Task<ModelConciseViewModel> GetModelByName();
    }
}
