using BoletoProject.Domain.Entities;
using MediatR;

namespace BoletoProject.Application.CQRS.Bancos.Queries
{
	public class GetBancoByIdQuery : IRequest<Banco>
	{
        public int Id { get; set; }

		public GetBancoByIdQuery(int id)
		{
			Id = id;
		}
	}
}
