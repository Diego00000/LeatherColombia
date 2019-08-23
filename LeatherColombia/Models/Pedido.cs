using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeatherColombia.Models
{
    public class Pedido
    {
        [Display(Name = "Pedido")]
        public int PedidoID { get; set; }
        [Display(Name = "Cliente")]
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
        [Display(Name = "MetodoPago")]
        public int MetodoPagoID { get; set; }
        public MetodoPago MetodoPago { get; set; }
        [Required]
        public int NumPedido { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime FechaSolicitud { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime FechaEnvio { get; set; }
        public Boolean Estado { get; set; } = true;
    }
}
