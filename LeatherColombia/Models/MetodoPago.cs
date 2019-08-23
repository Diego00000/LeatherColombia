using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeatherColombia.Models
{
    public class MetodoPago
    {
        public int MetodoPagoID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Referencia { get; set; }
    }
}
