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
    public class PersonRepository : RepositoryBase, IPersonRepository
    {
        private IWebApiDbContext _dbcontext;
        public PersonRepository(IWebApiDbContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task Add(Person person)
        {
            await _dbcontext.Add(person);
        }

        public async Task Edit(Person person)
        {
            await _dbcontext.Edit(person);
        }

        public async Task<Person> GetById(int personId)
        {
            return await _dbContext.PersonQuery.Where(x => x.Id == personId).FirstOrDefaultAsync();
        }
    }
}
