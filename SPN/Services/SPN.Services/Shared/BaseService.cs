namespace SPN.Services.Shared
{
    using AutoMapper;
    using SPN.Data;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseService
    {

        protected readonly IMapper mapper;
        protected readonly SPNDbContext dbContext;

        public BaseService(IMapper mapper, SPNDbContext dbContext)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

      
    }
}
