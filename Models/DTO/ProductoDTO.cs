using System.ComponentModel.DataAnnotations;

namespace Supletorio_Ing_Web.Models.DTO
{
    public class ProductoDTO
    {
        [Required]public string Nombre { get; set; }
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        public float Precio { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a 0")]
        public int Stock { get; set; }
        [Required]
        [Range(0, 1, ErrorMessage = "El descuento debe ser entre 0 y 1")]
        public float Descuento { get; set; }
    }
}
