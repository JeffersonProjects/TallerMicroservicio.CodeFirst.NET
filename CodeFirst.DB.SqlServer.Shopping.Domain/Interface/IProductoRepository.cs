﻿using CodeFirst.DB.SqlServer.Shopping.Domain.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DB.SqlServer.Shopping.Domain.Interface
{
    public interface IProductoRepository : IGenericRepository<Producto>
    {
        List<Producto> ListarDetalleProducto();
    }
}
