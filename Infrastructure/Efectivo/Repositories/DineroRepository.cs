using Domain.Efectivo.Entities;
using Domain.Efectivo.Repositories;
using System;
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

        public IList<Dinero> ActualizarDinero(IList<Dinero> refrescos)
        {
            //foreach (Dinero refresco in refrescos)
            //{
            //    refresco.CantidadDisponible -= Convert.ToInt32(refresco.CantidadSolicitada);
            //    refresco.CantidadSolicitada = 0;
            //}
            //_dbContext.Refrescos = refrescos;
            return _dbContext.Cambio;
        }
    }
}
