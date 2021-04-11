using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Natura.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required]
        public int Codigo { get; set; }

        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }

        public int IdLinea { get; set; }
        public Linea Linea { get; set; }



    }
}