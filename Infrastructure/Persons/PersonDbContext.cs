using Domain.Persons.Entities;
using System.Collections.Generic;

namespace Infrastructure.Persons
{
    internal class PersonDbContext
    {
        public PersonDbContext()
        {
        }

        public IList<Person> Persons { get; set; }

    }
}
