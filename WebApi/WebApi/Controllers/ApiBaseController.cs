using Microsoft.AspNetCore.Mvc;
using WebApi.UoWs;

namespace WebApi.Controllers
{
    public abstract class ApiBaseController : Controller
    {
        private UoWBase _uow;
        public ApiBaseController(UoWBase uow)
        {
            _uow = uow;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                _uow.Dispose();
            }
        }
    }
}
