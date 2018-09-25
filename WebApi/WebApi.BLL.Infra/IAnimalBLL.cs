using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.BLL.Infra
{
    public interface IAnimalBLL
    {
        Task AddAsync(Animal animal);
        Task EditAsync(Animal animal);
        Task<IList<Animal>> GetDonatedAnimalsAsync();
        Task<IList<Animal>> GetNotDonatedAnimalsAsync();
    }
}
