using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinicreg.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinicreg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
          
            var q = doctor.getdoctor();
            List<string> s = new List<string>();
            foreach (var p in q)
            {
                s.Add(p.name);
            }
            //return new string[] { "value1", "value2" };
            return s;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //todo 顯示科別:醫生....

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
