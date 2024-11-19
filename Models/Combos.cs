using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YohualkisTejada_AP1_P2.Models;

public class Combos
{
    [Key]
    public int ComboId { get; set; }

	[RegularExpression(@"^[a-zA-Z-ÁáÉéÍíÓóÚúÑñ\s]+$", ErrorMessage = "Este campo solo puede alojar letras/espacios.")]
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string Descripcion { get; set; } = string.Empty;

	[RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Este campo solo puede alojar numeros.")]
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public double Precio { get; set; }

	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public DateTime Fecha { get; set; } = DateTime.Now;


    public bool EstaVendido { get; set; } = false;

    [ForeignKey("ComboId")]
    public ICollection<CombosDetalles> Detalles { get; set; } = new List<CombosDetalles>();
}