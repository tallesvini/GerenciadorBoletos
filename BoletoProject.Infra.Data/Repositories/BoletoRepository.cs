using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Interfaces;
using BoletoProject.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BoletoProject.Infra.Data.Repositories
{
	public class BoletoRepository : IBoletoRepository
	{
		private readonly AppDbContext _dbContext;

		public BoletoRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task AddEntityAsync(Boleto entity)
		{
			if(entity == null) throw new ArgumentNullException(nameof(entity));

			await _dbContext.Set<Boleto>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<Boleto> GetByIdAsync(int id)
		{
			if(id == 0) throw new ArgumentNullException("'Id' cannot be empty.");

			return await _dbContext.Set<Boleto>().Include(x => x.Banco).FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
