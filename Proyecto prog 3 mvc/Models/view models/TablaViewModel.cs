using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_prog_3_mvc.Models.view_models
{
    public class TablaViewModel
    {// uso de datanotations para guardar los datos y hacer validaciones 
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name ="Ubicacion")]
        public string ubicacion { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Posicion")]
        public string posicion { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Compañia")]
        public string compañia { get; set; }
    }
}