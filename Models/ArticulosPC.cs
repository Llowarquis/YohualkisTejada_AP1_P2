using System.ComponentModel.DataAnnotations;

namespace YohualkisTejada_AP1_P2.Models;

public class ArticulosPC // El nombre de esta clase esta sujeta a cambios en el 2do parcial -> 18/11/2024
{
    [Key]
    public int ArticuloId { get; set; }
	public string? Descripcion { get; set; }

	public double Costo { get; set; }

	public double Precio { get; set; }

	public int Existencia { get; set; }
}
