using Domain.Efectivo.Entities;
using System.Collections.Generic;

namespace Infrastructure.Efectivo
{
    internal class DineroDbContext
    {
        public DineroDbContext()
        {
        }

        public IList<Dinero> Cambio { get; set; }

    }
}
