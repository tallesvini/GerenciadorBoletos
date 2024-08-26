using BoletoProject.Domain.Entities;
using MediatR;

namespace BoletoProject.Application.CQRS.Boletos.Commands
{
	public class BoletoCommand : IRequest<Boleto>
	{
		public string NomePagador { get; set; }
		public string CpfCnpjPagador { get; set; }
		public string NomeBeneficiario { get; set; }
		public string CpfCnpjBeneficiario { get; set; }
		public decimal Valor { get; set; }
		public DateTimeOffset DataVencimento { get; set; }
		public string? Observacao { get; set; }
        public int BancoId { get; set; }
    }
}
