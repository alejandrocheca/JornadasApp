using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace WorkDayTimerWebApp.Models
{
    public class WorkDayTimer
    {
        [Key]
        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public IdentityUser Usuario { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }

        [Range(0, 24)]
        public int HorasJornada { get; set; }

        [DataType(DataType.Duration)]
        public DateTime Tiempo { get; set; }

        public bool Corriendo { get; set; }

        [Range(0, 24)]
        public int MaxTiempo { get; set; }

    }
}