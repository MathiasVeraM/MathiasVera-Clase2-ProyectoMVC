using System.ComponentModel.DataAnnotations;

namespace MathiasVera_Clase2_ProyectoMVC.Models
{
    public class Carrera
    {
        // Atributos de la Carrera que el estudiante curse
        [Required]
        [Range(1, 1000)] // Anotacion que permite que el Id de la carrera este entre 1 y 1000
        public string Id { get; set; }
        public string Nombre { get; set; }
    }
}
