using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sunny_School.Pages.Info_Alumno
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public Prueba Enlace { get; set; }
        public class Prueba
        {

            [Required]
            [Display(Name = "Nombre:")]
            public string Nombre { get; set; }

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
            [Display(Name = "Genero:")]
            public string Genero { get; set; }

            [Required]
            [Display(Name = "¿Tiene alguna discapacidad?")]
            public string Discapacidad { get; set; }



        }
        

    }
}