using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

using LieuxDeFormationAPI.Models.TrainingProblem;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LieuxDeFormationAPI.Controllers
{
    [Route("api/[controller]")]
    public class AgenciesController : Controller
    {
        List<Agency> agencies;
        // GET: api/values
        [HttpGet]
        public IEnumerable<Agency> Get()
        {
            return agencies;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            System.Diagnostics.Debug.WriteLine(value);
            agencies.Add(new Agency());
            return HttpBadRequest();

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
