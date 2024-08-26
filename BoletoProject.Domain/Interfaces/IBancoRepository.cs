using BoletoProject.Domain.Entities;

namespace BoletoProject.Domain.Interfaces
{
	public interface IBancoRepository
	{
		Task<List<Banco>> GetAllAsync();
		Task<Banco> GetByCodigoBancoAsync(int id);
		Task AddEntityAsync(Banco entity);
	}
}
