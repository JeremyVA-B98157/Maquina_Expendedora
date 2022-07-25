using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Persons.Entities;

namespace Domain.Persons.Repositories
{
    public interface IPersonRepository
    {
        IList<Person> CrearInventario();
    }
}
