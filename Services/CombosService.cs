using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YohualkisTejada_AP1_P2.DAL;
using YohualkisTejada_AP1_P2.Models;

namespace YohualkisTejada_AP1_P2.Services;

public class CombosService(IDbContextFactory<Context> DbFactory)
{
	public async Task<bool> Guardar(Combos modelo)
	{
		if (!await Existe(modelo.ComboId))
			return await Insertar(modelo);
		else
			return await Modificar(modelo);
	}

	private async Task<bool> Existe(int id)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return await _contexto.Modelos
			.AnyAsync<Combos>(c => c.ComboId == id);
	}

	private async Task<bool> Insertar(Combos modelo)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		await AfectarArticulo(modelo.Detalles.ToArray(), true);
		_contexto.Modelos.Add(modelo);
		return await _contexto.SaveChangesAsync() > 0;
	}

	private async Task<bool> Modificar(Combos modelo)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();

		var modeloOriginal = await _contexto.Modelos
			.Include(t => t.Detalles)
			.FirstOrDefaultAsync(t => t.ComboId == modelo.ComboId);

		if (modeloOriginal == null)
			return false;

		await AfectarArticulo(modeloOriginal.Detalles.ToArray(), false);

		foreach (var detalleOriginal in modeloOriginal.Detalles)
		{
			if (!modelo.Detalles.Any(d => d.DetalleId == detalleOriginal.DetalleId))
			{
				_contexto.ModelosDetalles.Remove(detalleOriginal);
			}
		}

		await AfectarArticulo(modelo.Detalles.ToArray(), true);

		_contexto.Entry(modeloOriginal).CurrentValues.SetValues(modelo);

		foreach (var detalle in modelo.Detalles)
		{
			var detalleExistente = modeloOriginal.Detalles
				.FirstOrDefault(d => d.DetalleId == detalle.DetalleId);

			if (detalleExistente != null)
			{
				_contexto.Entry(detalleExistente).CurrentValues.SetValues(detalle);
			}
			else
			{
				modeloOriginal.Detalles.Add(detalle);
			}
		}

		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Eliminar(int id)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		var modelo = await _contexto.Modelos
			.Include(t => t.Detalles)
			.FirstOrDefaultAsync(t => t.ComboId == id);

		if (modelo == null)
			return false;

		await AfectarArticulo(modelo.Detalles.ToArray(), resta: false);

		_contexto.ModelosDetalles.RemoveRange(modelo.Detalles);
		_contexto.Modelos.Remove(modelo);

		var cantidad = await _contexto.SaveChangesAsync();
		return cantidad > 0;
	}

	public async Task<Combos?> Buscar(int id)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return await _contexto.Modelos
			.Include(m => m.Detalles)
			.FirstOrDefaultAsync(c => c.ComboId == id);
	}

	public async Task<List<Combos>> Listar(Expression<Func<Combos, bool>> criterio)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return await _contexto.Modelos
			.Include(m => m.Detalles)
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}

	private async Task AfectarArticulo(CombosDetalles[] detalle, bool resta = true)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		foreach (var item in detalle)
		{
			var Articulo = await _contexto.ArticulosModelos.SingleAsync(p => p.ArticuloId == item.ArticuloId);
			if (resta)
				Articulo.Existencia -= item.Cantidad;
			else
				Articulo.Existencia += item.Cantidad;
		}
		await _contexto.SaveChangesAsync();
	}
	public async Task<bool> ExisteNombre(int modeloId, string? name)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return await _contexto.Modelos
			.AnyAsync(e => e.ComboId != modeloId
			&& e.Descripcion.ToLower().Equals(name.ToLower()));
	}
}

