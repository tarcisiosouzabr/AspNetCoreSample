using WebApi.BLL.Infra;
using WebApi.DAL.Infra;

namespace WebApi.UoWs
{
    public class AnimalUoW : UoWBase
    {
        public IAnimalBLL AnimalBLL { get; set; }
        public AnimalUoW(IWebApiDbContext dbContext, IAnimalBLL animalBLL) : base(dbContext)
        {
            AnimalBLL = animalBLL;
        }
    }
}
