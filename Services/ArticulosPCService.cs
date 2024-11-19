using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YohualkisTejada_AP1_P2.DAL;
using YohualkisTejada_AP1_P2.Models;

namespace YohualkisTejada_AP1_P2.Services;

public class ArticulosPCService(IDbContextFactory<Context> DbFactory)
{
	public async Task<List<ArticulosPC>> Listar(Expression<Func<ArticulosPC, bool>> criterio)
	{
		await using var _contexto = await DbFactory.CreateDbContextAsync();
		return await _contexto.ArticulosModelos
			.Where(criterio)
			.AsNoTracking()
			.ToListAsync();
	}
}

