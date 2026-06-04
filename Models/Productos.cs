using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supletorio_Ing_Web.Models
{
    public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        public float Precio { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a 0")]
        public int Stock { get; set; }
        [Required]
        [Range(0, 1, ErrorMessage = "El descuento debe ser entre 0 y 1")]
        public float Descuento { get; set; }
        [Required]
        public float PrecioFinal { get; set; }
    }
}
