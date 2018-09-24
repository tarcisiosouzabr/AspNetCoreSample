using System;
using WebApi.DAL.Infra;

namespace WebApi.UoWs
{
    public class UoWBase : IDisposable
    {
        private IWebApiDbContext _dbContext;
        public UoWBase(IWebApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
