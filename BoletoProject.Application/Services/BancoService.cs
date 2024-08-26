using AutoMapper;
using BoletoProject.Application.CQRS.Bancos.Commands;
using BoletoProject.Application.CQRS.Bancos.Queries;
using BoletoProject.Application.DTOs;
using BoletoProject.Application.Interfaces;
using MediatR;

namespace BoletoProject.Application.Services
{
	public class BancoService : IBancoService
	{
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;

		public BancoService(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}

		public async Task AddEntityAsync(BancoCreatedDTO entity)
		{
			BancoCreateCommand command = _mapper.Map<BancoCreateCommand>(entity);
			await _mediator.Send(command);
		}

		public async Task<List<BancoDTO>> GetAllAsync()
		{
			GetBancoQuery bancoQuery = new GetBancoQuery();
			if (bancoQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(bancoQuery);
			var bancosDto = _mapper.Map<List<BancoDTO>>(result);

			if(bancosDto.Any())			
			{
				foreach(var banco in bancosDto)
				{
					foreach(var boleto in banco.Boletos)
					{
						if (DateTimeOffset.Now.ToLocalTime() >= boleto.DataVencimento) boleto.Valor = boleto.Valor + (boleto.Valor * banco.PercentualJuros / 100);					
					}
				}
			}

			return bancosDto;
		}
		public async Task<BancoDTO> GetByCodigoBancoAsync(int id)
		{
			GetBancoByIdQuery bancoQuery = new GetBancoByIdQuery(id);
			if(bancoQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(bancoQuery);
			var bancoDto = _mapper.Map<BancoDTO>(result);

			if(bancoDto != null)
			{
				foreach (var boleto in bancoDto.Boletos)
				{
					if (DateTimeOffset.Now.ToLocalTime() >= boleto.DataVencimento)
					{
						boleto.Valor = boleto.Valor + (boleto.Valor * bancoDto.PercentualJuros / 100);
					}
				}
			}

			return bancoDto;
		}
	}
}
