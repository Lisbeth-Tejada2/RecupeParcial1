using System.ComponentModel.DataAnnotations;

namespace RecupeParcial1.Models
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El concepto del prestamo es obligatorio")]
        public string Concepto { get; set; }


        [Required(ErrorMessage = "El monto solictado es obligatorio")]
        [Range(1, 1000000.00, ErrorMessage = "El monto mínimo y máximo debe ser entre {1} y {2}")]
        public float Monto { get; set; }

   
        [Required(ErrorMessage = "El Balance solicitado es obligatorio")]
        [Range(1, 2000000.00, ErrorMessage = "El Balance debe ser entre {1} y {2}")]
        public float Balance { get; set; }
    }
}
