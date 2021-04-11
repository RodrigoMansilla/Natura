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
       // public DbSet<IngresoGasto> IngresosGastos { get; set; }
    }
}