using Domain.Persons.Repositories;
using Domain.Persons.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Application.Persons.Implementations
{
    internal class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IList<Person> CrearInventario()
        {
            return _personRepository.CrearInventario();
        }
    }
}
