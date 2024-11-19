using Microsoft.EntityFrameworkCore;
using YohualkisTejada_AP1_P2.Models;

namespace YohualkisTejada_AP1_P2.DAL;

public class Context : DbContext
{
	public Context(DbContextOptions<Context> options) : base(options) { }

	public DbSet<Combos> Modelos { get; set; }
	public DbSet<CombosDetalles> ModelosDetalles { get; set; }
	public DbSet<ArticulosPC> ArticulosModelos { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<ArticulosPC>().HasData(new List<ArticulosPC>()
		{
			new ArticulosPC() { ArticuloId = 1, Descripcion = "Modulos RAM", Existencia = 51, Precio = 1999.99, Costo = 1999.99},
			new ArticulosPC() { ArticuloId = 2, Descripcion = "CPU", Existencia = 64, Precio = 9999.99, Costo = 3999.99},
			new ArticulosPC() { ArticuloId = 3, Descripcion = "Motherboards", Existencia = 85, Precio = 5449.99, Costo = 559.99},
			new ArticulosPC() { ArticuloId = 4, Descripcion = "Power Suplies", Existencia = 71, Precio = 4599.99, Costo = 7599.99},
			new ArticulosPC() { ArticuloId = 5, Descripcion = "Tarjetas de Video", Existencia = 84, Precio = 2699.50, Costo = 5769.80},
			new ArticulosPC() { ArticuloId = 6, Descripcion = "Cases", Existencia = 125, Precio = 3700, Costo = 1500}
		});
	}
}

