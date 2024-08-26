namespace BoletoProject.Application.DTOs
{
	public class BancoFkDTO : BaseDTO
	{
		public string? NomeBanco { get; set; }
		public int CodigoBanco { get; set; }
		public decimal PercentualJuros { get; set; }
	}
}
