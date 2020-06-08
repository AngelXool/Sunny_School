using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sunny_School.Pages.Info_Escolar
{
    public class CreateSecondModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public Alumno Enlace2 { get; set; }
        public class Alumno
        {

            [Required]
            [Display(Name = "Nombre completo del alumno:")]
            public string Nombre { get; set; }

            [Required]
            [Display(Name = "Nivel que cursa el Alumno")]
            public string Nivel { get; set; }

            [Required]
            [Display(Name = "Grado que cursa el Alumno")]
            public string Grado { get; set; }
        }
    }
}