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
    public class AnimalBLL : IAnimalBLL
    {
        private IWebApiDbContext _dbContext;
        private IAnimalRepository _animalRepository;
        private IPersonRepository _personRepository;
        public AnimalBLL(IWebApiDbContext dbContext, IAnimalRepository animalRepository, IPersonRepository personRepository)
        {
            _animalRepository = animalRepository;
            _dbContext = dbContext;
            _personRepository = personRepository;
        }
        public async Task AddAsync(Animal animal)
        {
            if (animal.PersonId.HasValue == true)
            {
                var person = _personRepository.GetById(animal.PersonId.Value);
                if (person == null)
                    throw new Exception("Pessoa não encontrada.");
            }
            await _animalRepository.Add(animal);
        }

        public async Task EditAsync(Animal animal)
        {
            if (animal.PersonId.HasValue == true)
            {
                var person = _personRepository.GetById(animal.PersonId.Value);
                if (person == null)
                    throw new Exception("Pessoa não encontrada.");
            }
            await _animalRepository.Edit(animal);
        }

        public async Task<IList<Animal>> GetDonatedAnimalsAsync()
        {
            return await _animalRepository.GetDonatedAnimals();
        }

        public async Task<IList<Animal>> GetNotDonatedAnimalsAsync()
        {
            return await _animalRepository.GetNotDonatedAnimals();
        }
    }
}
