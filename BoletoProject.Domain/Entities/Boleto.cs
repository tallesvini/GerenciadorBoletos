namespace BoletoProject.Domain.Entities
{
	public class Boleto : BaseEntity
	{
        public string NomePagador { get; private set; }
		public string CpfCnpjPagador { get; private set; }
        public string NomeBeneficiario { get; private set; }
        public string CpfCnpjBeneficiario { get; private set; }
        public decimal Valor { get; private set; }
        public DateTimeOffset DataVencimento { get; private set; }
        public string? Observacao { get; private set; }

        public int BancoId { get; private set; }
        public Banco Banco { get; private set; }

		public Boleto() { }

        public Boleto(string nomePagador, string cpfCnpjPagador, string nomeBeneficiario, string cpfCnpjBeneficiario, decimal valor, DateTimeOffset dataVencimento, string? observacao)
		{
			NomePagador = nomePagador;
			CpfCnpjPagador = cpfCnpjPagador;
			NomeBeneficiario = nomeBeneficiario;
			CpfCnpjBeneficiario = cpfCnpjBeneficiario;
			Valor = valor;
			DataVencimento = dataVencimento;
			Observacao = observacao;
		}
    }
}
