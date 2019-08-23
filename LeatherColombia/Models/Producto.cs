using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeatherColombia.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        [Required]
        public string NombreProducto { get; set; }
        [Required]
        public decimal Precio { get; set; }

    }
}
