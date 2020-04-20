using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Search;
using System.Collections.Generic;

namespace SPN.Auto.Web.ViewModels.Index
{
    public class IndexViewModel
    {
        public SearchConciseInputModel SearchConcise { get; set; }

        public IEnumerable<SearchResultConciseViewModel> NewestAdverts { get; set; }
    }
}
