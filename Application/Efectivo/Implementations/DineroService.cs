using Domain.Efectivo.Repositories;
using Domain.Efectivo.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Application.Efectivo.Implementations
{
    public class DineroService : IDineroService
    {
        private readonly IDineroRepository _dineroRepository;

        public DineroService(IDineroRepository dineroRepository)
        {
            _dineroRepository = dineroRepository;
        }

        public IList<Dinero> CrearFondo()
        {
            return _dineroRepository.CrearFondo();
        }

        public IList<Dinero> CrearListaCliente()
        { 
            return _dineroRepository.CrearListaCliente();
        }

        public IList<Dinero> ActualizarDinero(IList<Dinero> cambio)
        {
            return _dineroRepository.ActualizarDinero(cambio);
        }

        public double ObtenerMontoLista(IList<Dinero> dinero)
        {
            return _dineroRepository.ObtenerMontoLista(dinero);
        }

        public IList<Dinero> ObtenerVuelto(double vuelto)
        {
            return _dineroRepository.ObtenerVuelto(vuelto);
        }

        public IList<Dinero> PagarVuelto(IList<Dinero> dineroVuelto)
        {
            return _dineroRepository.PagarVuelto(dineroVuelto);
        }
    }
}
