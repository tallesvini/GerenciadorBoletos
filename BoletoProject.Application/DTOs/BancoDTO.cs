namespace BoletoProject.Application.DTOs
{
	public class BancoDTO : BaseDTO
	{
		public string? NomeBanco { get; set; }
		public int CodigoBanco { get; set; }
		public decimal PercentualJuros { get; set; }

		public ICollection<BoletoFkDTO> Boletos { get; set; }
	}
}
