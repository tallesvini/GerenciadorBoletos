using BoletoProject.Domain.Entities;
using MediatR;

namespace BoletoProject.Application.CQRS.Bancos.Queries
{
	public class GetBancoQuery : IRequest<IEnumerable<Banco>> { }
}
