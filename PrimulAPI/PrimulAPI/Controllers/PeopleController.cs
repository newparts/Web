using PrimulAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrimulAPI.Controllers
{
    public class PeopleController : ApiController
    {/// <summary>
    /// Aici o sa afisam toate informatiile despre oameni
    /// </summary>
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tatuc", LastName = "Gigi", Id = 1 });
            people.Add(new Person { FirstName = "Tat", LastName = "Gio", Id = 2 });
            people.Add(new Person { FirstName = "Tare", LastName = "Gigel", Id = 3 });
        }

        /// <summary>
        /// Creaza o lista cu Numele tuturor userilor
        /// </summary>
        /// <param name="userId">Identificatorul unic pentru fiecare user</param>
        /// <param name="age">Varsta fiecarui user</param>
        /// <returns>Returneaza o lista cu Numele userilor</returns>
       
        [Route("api/People/GetFirstNames/{userId:int}/P{age:int}")]
        [HttpGet]
        

        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }


        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
