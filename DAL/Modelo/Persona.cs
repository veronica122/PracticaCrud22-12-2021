using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Modelo
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        [Required(ErrorMessage = "Sus nombres son requeridos")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Sus apellidos son requeridos")]
        public string Apellidos { get; set; }
        [Required (ErrorMessage ="La edad es requerida") ]
        [Range(1,130, ErrorMessage = "La edad debe ser valida")]
        public int Edad { get; set; }
        [Required (ErrorMessage ="Debe seleccionar una opcion")]
        public bool Sexo { get; set; }
        [Required (ErrorMessage ="El telefono es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "La direccion es requerida")]
        public string Direccion { get; set; }
    }
}