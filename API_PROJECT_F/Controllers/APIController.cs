using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_PROJECT_F.Controllers
{
    public class APIController : ApiController
    {
        [Route("man/test")]
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        public List<string> get()
        {
            List<string> obj = new List<string>()
            {
                "manish",
                "aman",
                "shivam",
            };
            return obj;
        }
       
        
    }
}