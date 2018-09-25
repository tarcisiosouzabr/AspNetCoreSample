using System;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.DAL.Infra
{
    public interface IWebApiDbContext : IDisposable
    {
        #region Infra
        Task<int> SaveChangesAsync();
        Task Add<TEntity>(TEntity entity) where TEntity : class;
        Task Edit<TEntity>(TEntity entity) where TEntity : class;
        Task Delete<TEntity>(TEntity entity) where TEntity : class; 
        #endregion

        IQueryable<Person> PersonQuery { get; }
        IQueryable<Animal> AnimalQuery { get; }
    }
}
