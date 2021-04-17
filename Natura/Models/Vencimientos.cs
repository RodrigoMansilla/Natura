using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Natura.Models
{
    public class Vencimientos 
    {
        [Key]
        public int IdVencimiento{ get; set; }

        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        [Required]
        public DateTime FVencimiento { get; set; }

    }
}