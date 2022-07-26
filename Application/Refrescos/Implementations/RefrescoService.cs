using Domain.Refrescos.Repositories;
using Domain.Refrescos.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Application.Refrescos.Implementations
{
    internal class RefrescoService : IRefrescoService
    {
        private readonly IRefrescoRepository _refrescoRepository;

        public RefrescoService(IRefrescoRepository refrescoRepository)
        {
            _refrescoRepository = refrescoRepository;
        }

        public IList<Refresco> CrearInventario()
        {
            return _refrescoRepository.CrearInventario();
        }

        public IList<Refresco> ActualizarInventario(IList<Refresco> refrescos)
        {
            return _refrescoRepository.ActualizarInventario(refrescos);
        }
    }
}
