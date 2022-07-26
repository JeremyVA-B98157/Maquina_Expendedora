﻿using System.Collections.Generic;
using Domain.Efectivo.Entities;

namespace Domain.Efectivo.Repositories
{
    public interface IDineroRepository
    {
        IList<Dinero> CrearFondo();
        IList<Dinero> CrearListaCliente();
        IList<Dinero> ActualizarDinero(IList<Dinero> cambio);
    }
}
