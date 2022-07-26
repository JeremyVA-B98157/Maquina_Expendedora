using Domain.Core.Repositories;
using Domain.Refrescos.Entities;
using Domain.Refrescos.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

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
    }
}
