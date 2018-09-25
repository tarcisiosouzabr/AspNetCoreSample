using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.BLL.Infra;
using WebApi.DAL.Infra;
using WebApi.DAL.Infra.Repositories;
using WebApi.Entities;

namespace WebApi.BLL
{
    public class PersonBLL : IPersonBLL
    {
        private IWebApiDbContext _dbContext;
        private IPersonRepository _personRepository;
        public PersonBLL(IWebApiDbContext dbContext, IPersonRepository personRepository)
        {
            _dbContext = dbContext;
            _personRepository = personRepository;
        }
        public async Task AddAsync(Person person)
        {
            await _personRepository.Add(person);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Person person)
        {
            await _personRepository.Edit(person);
            await _dbContext.SaveChangesAsync();
        }
    }
}
