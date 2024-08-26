using BoletoProject.Domain.Entities;
using MediatR;

namespace BoletoProject.Application.CQRS.Bancos.Commands
{
	public class BancoCommand : IRequest<Banco>
	{
		public string? NomeBanco { get; set; }
		public int CodigoBanco { get; set; }
		public decimal PercentualJuros { get; set; }
	}
}
