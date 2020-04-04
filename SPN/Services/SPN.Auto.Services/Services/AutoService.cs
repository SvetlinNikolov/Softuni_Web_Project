using AutoMapper;
using SPN.Auto.Services.Contracts;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Services.Services
{
    public class AutoService :BaseService, IAutoService
    {
        public AutoService(IMapper mapper, SPNDbContext dbContext) 
            : base(mapper, dbContext)
        {
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public T GetByName<T>(string name)
        {
            throw new NotImplementedException();
        }
    }
}
