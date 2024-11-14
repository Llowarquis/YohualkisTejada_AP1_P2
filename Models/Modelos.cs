using System.ComponentModel.DataAnnotations;

namespace YohualkisTejada_AP1_P2.Models;

public class Modelos
{
    [Key]
    public int ModeloId { get; set; }

	public string Nombres { get; set; } = string.Empty;

	public int Sueldo { get; set; }

	public ICollection<ModeloDetalles> Detalles { get; set; } = new List<ModeloDetalles>();
}