﻿using Inventory.Models;
using InventoryWeb.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace InventoryWeb.Data.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio : IRepositorio<Categoria>
    {
        void Actualizar(Categoria categoria);
    }
}
