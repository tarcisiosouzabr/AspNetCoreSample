using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DAL.Infra;
using WebApi.DAL.Infra.Repositories;
using WebApi.Entities;

namespace WebApi.DAL.Repositories
{
    public class AnimalRepository : RepositoryBase, IAnimalRepository
    {
        private IWebApiDbContext _dbContext;
        public AnimalRepository(IWebApiDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Animal animal)
        {
           await _dbContext.Add(animal);
        }

        public async Task Edit(Animal animal)
        {
            await _dbContext.Edit(animal);
        }

        public async Task<IList<Animal>> GetDonatedAnimals()
        {
            return await _dbContext.AnimalQuery.Where(x => x.PersonId != null).ToListAsync();
        }

        public async Task<IList<Animal>> GetNotDonatedAnimals()
        {
            return await _dbContext.AnimalQuery.Where(x => x.PersonId == null).ToListAsync();
        }
    }
}
