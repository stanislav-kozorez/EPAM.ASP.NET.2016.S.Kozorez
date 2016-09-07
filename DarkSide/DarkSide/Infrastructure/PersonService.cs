using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkSide.Infrastructure
{
    public class PersonService
    {
        public List<Person> Persons
        {
            get
            {
                return new List<Person>()
                {
                    new Person() { Id = 0, Side = "light",},
                    new Person() { Id = 1, Side = "dark" },
                    new Person() { Id = 2, Side = "light" },
                    new Person() { Id = 3, Side = "light" },
                };
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Side { get; set; }
    }
}