using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Data.Models.Auto;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IAutoService
    {
        public Task CreateAutomobileAsync(MainCreateInputModel model);

        public Task EditAutomobileAsync(int id, EditAutomobileInputModel model);

        public Task<Automobile> GetAutomobileByIdAsync(int id);

        public Task<AutomobileViewModel> GetAutomobileViewModelByIdAsync(int id);

        public Task<EditAutomobileInputModel> GetAutomobileEditInputModelAsync(int id);

        public Task DeleteAutomobileAsync(int id);

        public Task<DeleteInputModel> GetAutomobileDeleteInputModelAsync(int id);
    }
}
