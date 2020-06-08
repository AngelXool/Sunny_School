using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sunny_School.Pages.NewFolder
{
    public class CreateThirdModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]

        public Familiar Enlace3 { get; set; }
        public class Familiar
        {

            [Required]
            [Display(Name = "Nombre del Tutor:")]
            public string Nombretutor { get; set; }

            [Required]
            [Display(Name = "C.U.R.P:")]
            public char CURP { get; set; }

            [Required]
            [Display(Name = "Nacionalidad:")]
            public string Nacionalidad { get; set; }

            [Required]
            [Display(Name = "Fecha de Nacimiento::")]
            public DateTime Fecha_Nacimineto { get; set; }

            [Required]
            [Display(Name = "Ocupacion:")]
            public string Ocupacion { get; set; }

            [Required]
            [Display(Name = "Nombre de la Madre:")]
            public string NombreMom { get; set; }

            [Required]
            [Display(Name = "Ingresos: $")]
            public string Ingresos { get; set; }
        }
    }
}