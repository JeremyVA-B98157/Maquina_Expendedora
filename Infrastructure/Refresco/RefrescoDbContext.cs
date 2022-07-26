using Domain.Refrescos.Entities;
using System.Collections.Generic;

namespace Infrastructure.Refrescos
{
    internal class RefrescoDbContext
    {
        public RefrescoDbContext()
        {
        }

        public IList<Refresco> Refrescos { get; set; }

    }
}
