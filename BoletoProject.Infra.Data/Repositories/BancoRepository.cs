using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Interfaces;
using BoletoProject.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BoletoProject.Infra.Data.Repositories
{
	public class BancoRepository : IBancoRepository
	{
		private readonly AppDbContext _dbContext;

		public BancoRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task AddEntityAsync(Banco entity)
		{
			if (entity == null) throw new ArgumentNullException(nameof(entity));

			await _dbContext.Set<Banco>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<Banco>> GetAllAsync()
		{
			return await _dbContext.Set<Banco>().Include(x => x.Boletos).ToListAsync();
		}

		public async Task<Banco> GetByCodigoBancoAsync(int id)
		{
			return await _dbContext.Set<Banco>().Include(x => x.Boletos).FirstOrDefaultAsync(x => x.CodigoBanco == id);
		}
	}
}
