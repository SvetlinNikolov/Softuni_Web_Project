
using SPN.Auto.Web.ViewModels.Make;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IMakeService
    {
        Task<IEnumerable<MakeConciseViewModel>> GetAllMakes();

        public Task<MakeConciseViewModel> GetMakeById();
    }
}
