using System.ComponentModel.DataAnnotations;

namespace Registros.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string TipoDocumento { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Debe ingresar un valor válido.")]
        public decimal ValorGanar { get; set; }

        public bool EstadoCivil { get; set; }
    }
}
