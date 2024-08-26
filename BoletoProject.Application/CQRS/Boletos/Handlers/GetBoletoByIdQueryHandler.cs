using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoletoProject.Application.CQRS.Boletos.Queries;
using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Interfaces;
using MediatR;

namespace BoletoProject.Application.CQRS.Boletos.Handlers
{
	public class GetBoletoByIdQueryHandler : IRequestHandler<GetBoletoByIdQuery, Boleto>
	{
		private readonly IBoletoRepository _boletoRepository;

		public GetBoletoByIdQueryHandler(IBoletoRepository boletoRepository)
		{
			_boletoRepository = boletoRepository;
		}

		public async Task<Boleto> Handle(GetBoletoByIdQuery request, CancellationToken cancellationToken)
		{
			return await _boletoRepository.GetByIdAsync(request.Id);
		}
	}
}
