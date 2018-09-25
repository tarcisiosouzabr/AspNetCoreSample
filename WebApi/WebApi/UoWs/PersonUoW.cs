using WebApi.BLL.Infra;
using WebApi.DAL.Infra;

namespace WebApi.UoWs
{
    public class PersonUoW : UoWBase
    {
        public IPersonBLL PersonBLL { get; set; }
        public PersonUoW(IWebApiDbContext dbContext, IPersonBLL personBLL) : base(dbContext)
        {
            PersonBLL = personBLL;
        }
    }
}
