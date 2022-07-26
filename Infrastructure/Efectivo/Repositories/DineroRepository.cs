using Domain.Efectivo.Entities;
using Domain.Efectivo.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Efectivo.Repositories
{
    internal class DineroRepository : IDineroRepository
    {
        private readonly DineroDbContext _dbContext;

        public DineroRepository()
        {
            _dbContext = new DineroDbContext();
        }

        public IList<Dinero> CrearFondo()
        {
            _dbContext.Cambio = new List<Dinero>() {
                new Dinero(500.0, 20),
                new Dinero(100.0, 30),
                new Dinero(50.0, 50),
                new Dinero(25.0, 25),
            };
            return _dbContext.Cambio;
        }

        public IList<Dinero> CrearListaCliente()
        {
            IList<Dinero> dineroCliente = new List<Dinero>() {
                new Dinero(1000.0, 0),
                new Dinero(500.0, 0),
                new Dinero(100.0, 0),
                new Dinero(50.0, 0),
                new Dinero(25.0, 0),
            };
            return dineroCliente;
        }

        public IList<Dinero> ActualizarDinero(IList<Dinero> dineroCliente)
        {
            foreach (Dinero dinero in dineroCliente)
            {
                if (dinero.Cantidad > 0)
                {
                    if (dinero.Denominacion != 1000.0)
                    {
                        _dbContext.Cambio.Where(e => e.Denominacion == dinero.Denominacion).FirstOrDefault().Cantidad += dinero.Cantidad;
                    }
                }

            }
            return _dbContext.Cambio;
        }

        public double ObtenerMontoLista(IList<Dinero> dinero)
        {
            double monto = 0;
            foreach (Dinero moneda in dinero)
            {
                monto += moneda.Denominacion * moneda.Cantidad;
            }
            return monto;
        }
    }
}
