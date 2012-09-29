using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class cliente
    {
        [Required]
        [Display(Name = "Nombre : ")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Ap. Pat. : ")]
        public string Ap{ get; set; }
        [Required]
        [Display(Name = "Ap. Mat. : ")]
        public string Am { get; set; }
        [Required]
        [Display(Name = "Documento de Identidad : ")]
        public string Di { get; set; }
        [Required]
        [Display(Name = "Tipo de Documento : ")]
        public string Td { get; set; }
        [Required ]
        [Display(Name = "Pais : ")]
        public string pa { get; set; }
        [Required]
        [Display(Name = "Ciudad : ")]
        public string ciu { get; set; }
        [Required]
        [Display(Name = "Dirección : ")]
        public string dir { get; set; }
        [Required]
        [Display(Name = "Email : ")]
        public string e { get; set; }
        [Required]
        [Display(Name = "Telefono : ")]
        public int t { get; set; }
        [Required]
        [Display(Name = "Fecha de Nacimiento : ")]
        public string fn { get; set; }
    }
}