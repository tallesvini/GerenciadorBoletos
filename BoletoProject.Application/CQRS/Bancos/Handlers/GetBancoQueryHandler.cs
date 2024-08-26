using BoletoProject.Application.CQRS.Bancos.Queries;
using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Interfaces;
using MediatR;

namespace BoletoProject.Application.CQRS.Bancos.Handlers
{
	public class GetBancoQueryHandler : IRequestHandler<GetBancoQuery, IEnumerable<Banco>>
	{
		private readonly IBancoRepository _bancoRepository;

		public GetBancoQueryHandler(IBancoRepository bancoRepository)
		{
			_bancoRepository = bancoRepository;
		}

		public async Task<IEnumerable<Banco>> Handle(GetBancoQuery request, CancellationToken cancellationToken)
		{
			return await _bancoRepository.GetAllAsync();
		}
	}
}
