﻿using System.Collections.Generic;
using Domain.Refrescos.Entities;

namespace Domain.Refrescos.Repositories
{
    public interface IRefrescoRepository
    {
        IList<Refresco> CrearInventario();
    }
}