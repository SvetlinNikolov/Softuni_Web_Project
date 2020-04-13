using AutoMapper;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class AutoService :BaseService, IAutoService
    {
        public AutoService(IMapper mapper, SPNDbContext dbContext) 
            : base(mapper, dbContext)
        {
        }

        public async Task<MainCreateInputModel> CreateAutomobileAsync()
        {
            return null;
        }
    }
}
