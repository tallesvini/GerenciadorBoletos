namespace BoletoProject.Application.DTOs
{
	public class BoletoFkDTO : BaseDTO
	{
		private DateTimeOffset _dataVencimento;

		public string NomePagador { get; set; }
		public string CpfCnpjPagador { get; set; }
		public string NomeBeneficiario { get; set; }
		public string CpfCnpjBeneficiario { get; set; }
		public decimal Valor { get; set; }
		public DateTimeOffset DataVencimento { get => _dataVencimento.ToLocalTime(); set => _dataVencimento = value; }
		public string? Observacao { get; set; }
		public int BancoId { get; set; }
	}
}
