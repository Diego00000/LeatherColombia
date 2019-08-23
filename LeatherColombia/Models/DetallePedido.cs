using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeatherColombia.Models
{
    public class DetallePedido
    {
        [Display(Name = "Detalle Pedido")]
        public int DetallePedidoID { get; set; }
        [Display(Name = "Producto")]
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
        [Display(Name = "Pedido")]
        public int PedidoID { get; set; }
        public Pedido Pedido { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public decimal Total { get; set; }
       
        public Boolean Estado { get; set; } = true;
    }
}
