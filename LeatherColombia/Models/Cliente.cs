using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeatherColombia.Models
{
    public class Cliente
    {
        [Display(Name = "Cliente")]
        public int ClienteID { get; set; }
        [Display(Name = "Pais")]
        public int PaisID { get; set; }
        public Pais Pais { get; set; }
        [Display(Name = "Ciudad")]
        public int CiudadID { get; set; }
        public Ciudad Ciudad { get; set; }
        [Required]       
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Telefono { get; set; }
        public Boolean Estado { get; set; } = true;
    }
}
