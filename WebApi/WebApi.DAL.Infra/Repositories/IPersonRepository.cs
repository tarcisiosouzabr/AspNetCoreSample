using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.DAL.Infra.Repositories
{
    public interface IPersonRepository
    {
        Task Add(Person person);
        Task Edit(Person person);
        Task<Person> GetById(int personId);
    }
}
