using AutoMapper;
using BoletoProject.Application.CQRS.Boletos.Commands;
using BoletoProject.Application.CQRS.Boletos.Queries;
using BoletoProject.Application.DTOs;
using BoletoProject.Application.Interfaces;
using MediatR;

namespace BoletoProject.Application.Services
{
	public class BoletoService : IBoletoService
	{
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;

		public BoletoService(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}

		public async Task AddEntityAsync(BoletoCreatedDTO entity)
		{
			BoletoCreateCommand command = _mapper.Map<BoletoCreateCommand>(entity);
			await _mediator.Send(command);
		}

		public async Task<BoletoDTO> GetByIdAsync(int id)
		{
			GetBoletoByIdQuery boletoQuery = new GetBoletoByIdQuery(id);
			if (boletoQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(boletoQuery);
			var boleto = _mapper.Map<BoletoDTO>(result);

			if(boleto != null)
			{
				if(DateTimeOffset.Now.ToLocalTime() >= boleto.DataVencimento) boleto.Valor = boleto.Valor + (boleto.Valor * boleto.Banco.PercentualJuros / 100);
			}

			return boleto;
		}
	}
}
