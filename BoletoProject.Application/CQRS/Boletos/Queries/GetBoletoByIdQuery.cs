using BoletoProject.Domain.Entities;
using MediatR;

namespace BoletoProject.Application.CQRS.Boletos.Queries
{
	public class GetBoletoByIdQuery : IRequest<Boleto>
	{
		public int Id { get; set; }

		public GetBoletoByIdQuery(int id)
		{
			Id = id;
		}
	}
}
