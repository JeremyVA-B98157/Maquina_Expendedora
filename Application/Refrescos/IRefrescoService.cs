using Domain.Refrescos.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Refrescos
{
    public interface IRefrescoService
    {
        IList<Refresco> CrearInventario();
        IList<Refresco> ActualizarInventario(IList<Refresco> refrescos);
    }
}
