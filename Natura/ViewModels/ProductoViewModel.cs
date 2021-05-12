using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Natura.ViewModels
{
    public class ProductoViewModel
    {

        public int IdProducto { get; set; }
        public string Nombre { get; set; }

        public int Codigo { get; set; }

        public string NombreCategoria { get; set; }
        public string NombreLinea { get; set; }

    }
}