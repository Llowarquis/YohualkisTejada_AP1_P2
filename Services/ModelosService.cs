using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YohualkisTejada_AP1_P2.DAL;
using YohualkisTejada_AP1_P2.Models;

namespace YohualkisTejada_AP1_P2.Services;

public class ModelosService(IDbContextFactory<Context> DbFactory)
{
	public async Task<bool> Guardar(Modelos modelo)
	{
		if (!await Existe(modelo.ModeloId))
			return await Insertar(modelo);
		else
			return await Modificar(modelo);
	}

	private async Task<bool> Existe(int id)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return false;
	}

	private async Task<bool> Insertar(Modelos modelo)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return false;
	}

	private async Task<bool> Modificar(Modelos modelo)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return false;
	}

	public async Task<bool> Eliminar(int id)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
	
		return false;
	}

	public async Task<Modelos?> Buscar(int id)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return null;
	}

	public async Task<List<Modelos>> Listar(Expression<Func<Modelos, bool>> criterio)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return null;
	}

	private async Task AfectarArticulo(ModelosDetalles[] detalle, bool resta = true)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();

	}
}
