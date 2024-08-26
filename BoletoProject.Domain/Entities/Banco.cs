namespace BoletoProject.Domain.Entities
{
	public class Banco : BaseEntity
	{
        public string? NomeBanco { get; private set; }
        public int CodigoBanco { get; private set; }
        public decimal PercentualJuros { get; private set; }
        public ICollection<Boleto>? Boletos { get; private set; }

		public Banco() { }

        public Banco(string nomeBanco, int codigoBanco, decimal percentualJuros, ICollection<Boleto> boletos)
		{
			NomeBanco = nomeBanco;
			CodigoBanco = codigoBanco;
			PercentualJuros = percentualJuros;
			Boletos = boletos;
		}
    }
}
