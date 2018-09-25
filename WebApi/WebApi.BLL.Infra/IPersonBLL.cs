using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.BLL.Infra
{
    public interface  IPersonBLL
    {
        Task AddAsync(Person person);
        Task EditAsync(Person person);
    }
}
