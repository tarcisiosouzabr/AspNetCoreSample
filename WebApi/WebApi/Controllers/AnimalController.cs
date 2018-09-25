using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
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

        [Route("api/animal/donatedanimals"), HttpGet]
        public async Task<IActionResult> GetDonatedAnimals()
        {
            return Ok(await _uow.AnimalBLL.GetDonatedAnimalsAsync());
        }

        [Route("api/animal/notdonatedanimals"), HttpGet]
        public async Task<IActionResult> GetNotDonatedAnimals()
        {
            return Ok(await _uow.AnimalBLL.GetNotDonatedAnimalsAsync());
        }

        [Route("api/animal/add"), HttpPost]
        public async Task<IActionResult> PostAdd([FromBody] Animal animal)
        {
            await _uow.AnimalBLL.AddAsync(animal);
            return Ok();
        }

        [Route("api/animal/edit"), HttpPost]
        public async Task<IActionResult> PostEdit([FromBody] Animal animal)
        {
            await _uow.AnimalBLL.EditAsync(animal);
            return Ok();
        }
    }
}