using System.ComponentModel.DataAnnotations;

namespace ExamenSegunda.Components.Data
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número positivo")]
        public int NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(200, ErrorMessage = "El nombre no puede exceder 200 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El departamento es obligatorio")]
        [RegularExpression("Frutas|Verduras|Lácteos", ErrorMessage = "Departamento inválido")]
        public string Departamento { get; set; } = string.Empty;
    }
}
