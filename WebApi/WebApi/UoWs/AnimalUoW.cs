using WebApi.DAL.Infra;

namespace WebApi.UoWs
{
    public class AnimalUoW : UoWBase
    {
        public AnimalUoW(IWebApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
