using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YohualkisTejada_AP1_P2.Models;

public class CombosDetalles
{
    [Key]
    public int DetalleId { get; set; }
    [ForeignKey("Combos")]
    public int ComboId { get; set; }
    public int ArticuloId { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
}
