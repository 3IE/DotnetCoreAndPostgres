using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class DBController : Controller
    {
        // GET api/db
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            using (var db = new PersonsContext())
            {
                var persons = db.persons.OrderBy(p => p.Id);
                return persons.ToList();
            }
            
        }
    }
}
