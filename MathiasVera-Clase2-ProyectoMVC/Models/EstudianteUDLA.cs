using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MathiasVera_Clase2_ProyectoMVC.Models
{
    //  Anotacion que afecta a toda la clase viene aqui ,  se puede excluir cosas
    public class EstudianteUDLA
    {
        // Atributos de estudiante UDLA

        [Required] // Anotacion que sirve para que el IDBanner sea requerido de llenar
        public string IDBanner { get; set; }

        [AllowNull] // Esta anotacion sirve para habilitar que el correo acepte nulos, igual el ?
        [EmailAddress] // Esta anotacion sirve para validar que el usuario ingrese un correo valido en el formulario de vistas
        public string? Correo {  get; set; }

        [MaxLength(200)] // Permite que el nombre del estudiante tenga una longitud max de 100 caracteres
        public string Nombre { get; set; }
        public Carrera Carrera { get; set; }

    }

}
