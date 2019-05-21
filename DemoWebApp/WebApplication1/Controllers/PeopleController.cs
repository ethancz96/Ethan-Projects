using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        // Constructor
        PeopleController()
        {
            people.Add(new Person
            {
                FirstName = "Tim",
                LastName = "Corey",
                Id = 1,
                Age = 25

            });

            people.Add(new Person
            {
                FirstName = "Ethan",
                LastName = "Chen",
                Id = 2,
                Age = 22

            });

            people.Add(new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Id = 3,
                Age = 29

            });
        }

        [HttpGet] // Only allow HTTP Get verb
        [Route("api/People/getFirstNames")] // Route this function to this URL
        public List<string> getFirstName()
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }


        [HttpGet]
        [Route("api/People/getPersonByAge/{age:int}")]
        public List<Person> getPersonByAge(int age)
        {
            List<Person> output = new List<Person>();
            output.Add(people.Find(p => (p.Age == age)));
            return output;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people; // Returns the list of persons
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

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
