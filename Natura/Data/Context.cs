using Natura.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Natura.Data
{
    public class Context: DbContext
    {
        public Context() : base("DefaultConnection")
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias{ get; set; }
        public DbSet<Linea> Lineas { get; set; }

        public DbSet<ProductoEnCasa> ProductsoEnCasa { get; set; }
        public DbSet<Vencimientos> Vencimientos { get; set; }

    }
}