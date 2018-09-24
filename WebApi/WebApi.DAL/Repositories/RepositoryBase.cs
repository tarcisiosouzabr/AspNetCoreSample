using WebApi.DAL.Infra;

namespace WebApi.DAL.Repositories
{
    public abstract class RepositoryBase
    {
        protected IWebApiDbContext _dbContext;

        public RepositoryBase(IWebApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
