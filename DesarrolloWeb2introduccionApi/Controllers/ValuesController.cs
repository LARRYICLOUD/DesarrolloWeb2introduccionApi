using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DesarrolloWeb2introduccionApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()//obtener
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values recibe una cadena de caracteres o cuerpo de caracteres
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5  //Actualizar
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
