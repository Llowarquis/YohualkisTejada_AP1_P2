using Microsoft.EntityFrameworkCore;
using YohualkisTejada_AP1_P2.Models;

namespace YohualkisTejada_AP1_P2.DAL;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }

    public DbSet<Modelos> Modelos { get; set; }
    public DbSet<ModelosDetalles> ModelosDetalles { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}
