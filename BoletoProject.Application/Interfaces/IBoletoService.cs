using BoletoProject.Application.DTOs;

namespace BoletoProject.Application.Interfaces
{
	public interface IBoletoService
	{
		Task AddEntityAsync(BoletoCreatedDTO entity);
		Task<BoletoDTO> GetByIdAsync(int id);
	}
}
