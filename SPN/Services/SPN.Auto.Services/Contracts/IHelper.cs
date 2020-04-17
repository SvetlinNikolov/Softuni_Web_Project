using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System.Linq;

namespace SPN.Auto.Services.Contracts
{
    public interface IHelper
    {
        public  IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles);

    }
}
