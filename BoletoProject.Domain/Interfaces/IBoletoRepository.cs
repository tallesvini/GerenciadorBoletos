using BoletoProject.Domain.Entities;

namespace BoletoProject.Domain.Interfaces
{
	public interface IBoletoRepository
	{
		Task AddEntityAsync(Boleto entity);
		Task<Boleto> GetByIdAsync(int id);
	}
}
