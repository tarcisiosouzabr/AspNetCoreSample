using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.UoWs;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    public class AnimalController : ApiBaseController
    {
        private AnimalUoW _uow;
        public AnimalController(AnimalUoW uow) : base(uow)
        {
            _uow = uow;
        }

        [Route("api/animal"), HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new { Dog = "Rex" });
        }
    }
}