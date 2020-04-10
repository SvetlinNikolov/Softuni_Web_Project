using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Contracts
{
    public interface IAutoService
    {
        public Task<> CreateAutomobileAsync { get; set; }

    }
}
