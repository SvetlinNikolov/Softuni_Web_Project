using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.ViewModels.Make;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class MakeService : BaseService, IMakeService
    {
        public MakeService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task<IEnumerable<MakeConciseViewModel>> GetAllMakes()
        {
            var makes = await this.dbContext
                .Makes
                .Select(m => new MakeConciseViewModel { Name = m.Name })
                .ToListAsync();
           
            //var carMakes = mapper
            //      .Map<IEnumerable<MakeConciseViewModel>>(makes); //Map

            return makes;
        }


    }
}
