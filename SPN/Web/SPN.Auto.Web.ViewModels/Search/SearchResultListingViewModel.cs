using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.ViewModels.Search
{
    public class SearchResultListingViewModel
    {
        public string Title { get; set; } //Type here searching for : Audi/Year-From-To somethign like that

        public IEnumerable<SearchResultConciseViewModel> SearchResults { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }

    }
}
