using SPN.Forum.Web.InputModels.Home;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IMakeService
    {
        Task<MakesListingViewModel> GetAllMakes();


    }
}
