using BoletoProject.Application.CQRS.Bancos.Queries;
using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Interfaces;
using MediatR;

namespace BoletoProject.Application.CQRS.Bancos.Handlers
{
	public class GetBancoByIdQueryHandler : IRequestHandler<GetBancoByIdQuery, Banco>
	{
		private readonly IBancoRepository _bancoRepository;

		public GetBancoByIdQueryHandler(IBancoRepository bancoRepository)
		{
			_bancoRepository = bancoRepository;
		}

		public async Task<Banco> Handle(GetBancoByIdQuery request, CancellationToken cancellationToken)
		{
			return await _bancoRepository.GetByCodigoBancoAsync(request.Id);
		}
	}
}
