using System.ComponentModel.DataAnnotations;

namespace YohualkisTejada_AP1_P2.Models;

public class ModeloDetalles
{
    [Key]
    public int DetalleId { get; set; }

    public int Cantidad { get; set; }
}
