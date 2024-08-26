using BoletoProject.Application.DTOs;

namespace BoletoProject.Application.Interfaces
{
	public interface IBancoService
	{
		Task<List<BancoDTO>> GetAllAsync();
		Task<BancoDTO> GetByCodigoBancoAsync(int id);
		Task AddEntityAsync(BancoCreatedDTO entity);
	}
}
