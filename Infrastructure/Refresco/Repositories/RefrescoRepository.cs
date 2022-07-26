using Domain.Refrescos.Entities;
using Domain.Refrescos.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Refrescos.Repositories
{
    internal class RefrescoRepository : IRefrescoRepository
    {
        private readonly RefrescoDbContext _dbContext;

        public RefrescoRepository()
        {
            _dbContext = new RefrescoDbContext();
        }

        public IList<Refresco> CrearInventario()
        {
            _dbContext.Refrescos = new List<Refresco>() {
                new Refresco(10, "Coca Cola", 500.0, 0),
                new Refresco(8, "Pepsi", 600.0, 0),
                new Refresco(10, "Fanta", 550.0, 0),
                new Refresco(15, "Sprite", 725.0, 0),
            };
            return _dbContext.Refrescos;
        }

        public IList<Refresco> ActualizarInventario(IList<Refresco> refrescos)
        {
            foreach (Refresco refresco in refrescos.Where(e => e.CantidadSolicitada > 0))
            {
                refresco.CantidadDisponible -= Convert.ToInt32(refresco.CantidadSolicitada);
                refresco.CantidadSolicitada = 0;
            }
            _dbContext.Refrescos = refrescos;
            return _dbContext.Refrescos;
        }

        public double ObtenerPrecioTotal(IList<Refresco> refrescos)
        {
            double monto = 0;
            foreach (Refresco refresco in refrescos.Where(e => e.CantidadSolicitada > 0))
            {
                monto += refresco.Precio * Convert.ToDouble(refresco.CantidadSolicitada);
            }
            return monto;
        }
    }
}
