using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPICrud.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Models.Generic2dModel> Get()
        {
            DAL.WebAPiEntities entities = new DAL.WebAPiEntities();
            var result = entities.Classes.Select(s => new Models.Generic2dModel() {
                    Id=s.Id,
                    Name=s.Name
            }).ToList();
            return result; 
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
