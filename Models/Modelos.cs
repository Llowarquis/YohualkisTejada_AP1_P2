using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YohualkisTejada_AP1_P2.Models;

public class Modelos
{
    [Key]
    public int ModeloId { get; set; }

	[RegularExpression(@"^[a-zA-Z-ÁáÉéÍíÓóÚúÑñ\s]+$", ErrorMessage = "Este campo solo puede alojar letras/espacios.")]
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string Nombres { get; set; } = string.Empty;

	[RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Este campo solo puede alojar numeros.")]
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public int Sueldo { get; set; }

	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public DateTime Fecha { get; set; } = DateTime.Now;

	[ForeignKey("ModeloId")]
    public ICollection<ModelosDetalles> Detalles { get; set; } = new List<ModelosDetalles>();
}