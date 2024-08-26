using BoletoProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BoletoProject.Infra.Data.Configuration
{
	public class BancoConfiguration : IEntityTypeConfiguration<Banco>
	{
		public void Configure(EntityTypeBuilder<Banco> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.NomeBanco).HasMaxLength(128).IsRequired();
			builder.Property(x => x.CodigoBanco).IsRequired();
			builder.Property(x => x.PercentualJuros).IsRequired();

			builder.HasMany(y => y.Boletos);
		}
	}
}
