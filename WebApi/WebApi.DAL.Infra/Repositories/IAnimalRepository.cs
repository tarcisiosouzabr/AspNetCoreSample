using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.DAL.Infra.Repositories
{
    public interface IAnimalRepository
    {
        Task Add(Animal animal);
        Task Edit(Animal animal);
        Task<IList<Animal>> GetDonatedAnimals();
        Task<IList<Animal>> GetNotDonatedAnimals();
    }
}
