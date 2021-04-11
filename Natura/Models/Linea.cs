using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Natura.Models
{
    public class Linea
    {
        [Key]
        public int IdLinea { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nombre { get; set; }
    }
}