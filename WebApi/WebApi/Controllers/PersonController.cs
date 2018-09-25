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
    public class PersonController : ApiBaseController
    {
        private PersonUoW _uow;
        public PersonController(PersonUoW uow) : base (uow)
        {
            _uow = uow;
        }

        [Route("api/person/add"), HttpPost]
        public async Task<IActionResult> PostAdd([FromBody] Person person)
        {
            await _uow.PersonBLL.AddAsync(person);
            return Ok();
        }

        [Route("api/person/edit"), HttpPost]
        public async Task<IActionResult> PostEdit([FromBody] Person person)
        {
            await _uow.PersonBLL.EditAsync(person);
            return Ok();
        }
    }
}