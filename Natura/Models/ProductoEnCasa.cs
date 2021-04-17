using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Natura.Models
{
    public class ProductoEnCasa
    {
        [Key]
        public int IdProductoEncasa { get; set; }

        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string DondeEsta { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string Comentario { get; set; }



    }
}