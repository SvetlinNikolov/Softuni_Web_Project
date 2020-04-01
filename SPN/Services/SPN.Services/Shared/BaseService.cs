namespace SPN.Forum.Services.Shared
{
    using AutoMapper;
    using SPN.Forum.Data;

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
