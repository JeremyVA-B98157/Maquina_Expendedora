using Domain.Core.Repositories;
using Domain.Persons.Entities;
using Domain.Persons.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Infrastructure.Persons.Repositories
{
    internal class PersonRepository : IPersonRepository
    {
        private readonly PersonDbContext _dbContext;

        public PersonRepository()
        {
            _dbContext = new PersonDbContext();
        }

        public IList<Person> CrearInventario()
        {
            _dbContext.Persons = new List<Person>() {
                new Person(10, "Coca Cola", 500.0, 0),
                new Person(8, "Pepsi", 600.0, 0),
                new Person(10, "Fanta", 550.0, 0),
                new Person(15, "Sprite", 725.0, 0),
            };
            return _dbContext.Persons;
        }
    }
}
