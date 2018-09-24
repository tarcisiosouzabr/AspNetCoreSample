using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DAL.Infra;
using WebApi.Entities;

namespace WebApi.DAL
{
    public class WebApiDbContext : DbContext, IWebApiDbContext
    {
        public WebApiDbContext(DbContextOptions op) : base (op)
        {

        }

        public Task Delete<TEntity>(TEntity entity) where TEntity : class
        {
            return Task.Run(() =>
            {
                base.Remove(entity);
            });
        }

        public Task Edit<TEntity>(TEntity entity) where TEntity : class
        {
            return Task.Run(() =>
            {
                base.Update(entity);
            });
        }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        Task IWebApiDbContext.Add<TEntity>(TEntity entity)
        {
            return Task.Run(() =>
            {
                base.Add(entity);
            });
        }

        public DbSet<User> User { get; set; }
        public IQueryable<User> UserQuery { get { return UserQuery; } }
    }
}
