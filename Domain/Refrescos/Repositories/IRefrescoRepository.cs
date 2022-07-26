using System.Collections.Generic;
using Domain.Refrescos.Entities;

namespace Domain.Refrescos.Repositories
{
    public interface IRefrescoRepository
    {
        IList<Refresco> CrearInventario();
        IList<Refresco> ActualizarInventario(IList<Refresco> refrescos);
        double ObtenerPrecioTotal(IList<Refresco> refrescos);
    }
}
