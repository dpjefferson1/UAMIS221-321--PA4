using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        // GET: api/Activities
        [HttpGet]
        public List<string> Get()
        {
            List<string> myStrings = new List<string>();
            myStrings.Add();
            return myStrings;
        }

        // GET: api/Activities/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Activities
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Activities/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Activities/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
