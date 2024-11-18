using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YohualkisTejada_AP1_P2.Models;

public class ModelosDetalles
{
    [Key]
    public int DetalleId { get; set; }


	[Required(ErrorMessage = "Este campo es obligatorio")]
	public int Cantidad { get; set; }


	[Required(ErrorMessage = "Este campo es obligatorio")]
	public double Precio { get; set; }


    [Required(ErrorMessage = "Este campo es obligatorio")]
    [ForeignKey("Articulos")]
	public int ArticuloId { get; set; }
	public ArticulosModelos? Articulos { get; set; }
}
