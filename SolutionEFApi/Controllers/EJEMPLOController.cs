using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SolutionEFApi.Controllers
{
    public class EJEMPLOController : ApiController
    {
        // GET: api/EJEMPLO
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EJEMPLO/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EJEMPLO
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EJEMPLO/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EJEMPLO/5
        public void Delete(int id)
        {
        }
    }
}
