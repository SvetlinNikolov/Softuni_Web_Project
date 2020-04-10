using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IAutoSearchService
    {
        public Task<int> GetSearchResults(); //TODO this has to be a viewModel


    }
}
