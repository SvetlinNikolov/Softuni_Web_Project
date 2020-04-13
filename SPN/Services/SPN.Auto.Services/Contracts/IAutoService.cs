using SPN.Auto.Web.InputModels.Automobile;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IAutoService
    {
        public Task CreateAutomobileAsync(MainCreateInputModel model);
    }
}
