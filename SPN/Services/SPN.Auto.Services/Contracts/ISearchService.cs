using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Auto.Web.ViewModels.Search;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface ISearchService
    {
        public Task<SearchResultListingViewModel> GetSearchResultsAsync(MainSearchInputModel inputModel, int? take = null, int skip = 0);

        public Task<SearchResultListingViewModel> GetNewestAdvertsAsync(int? take = null, int skip = 0);


        public bool SearchModelIsNull(object inputModel);

        public int GetAutomobilesCount();

        public Task<IEnumerable<SearchResultConciseViewModel>> GetNewestAdvertsConciseAsync(int? take =null);

    }
}
