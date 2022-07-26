using Domain.Efectivo.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Efectivo
{
    public interface IDineroService
    {
        IList<Dinero> CrearFondo();
        IList<Dinero> CrearListaCliente();
        IList<Dinero> ActualizarDinero(IList<Dinero> cambio);
        double ObtenerMontoLista(IList<Dinero> dinero);
    }
}
