using Domain.Persons.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Persons
{
    public interface IPersonService
    {
        IList<Person> CrearInventario();
    }
}
