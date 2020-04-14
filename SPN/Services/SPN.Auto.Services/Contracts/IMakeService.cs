
using SPN.Auto.Web.ViewModels.Make;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IMakeService
    {
        Task<IEnumerable<MakeConciseViewModel>> GetAllMakesAsync();

        public Task<MakeConciseViewModel> GetMakeByIdAsync(int id);

        public Task<MakeConciseViewModel> GetMakeByNameAsync(string name);
    }
}
