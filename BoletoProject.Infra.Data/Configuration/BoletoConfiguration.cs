using BoletoProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoletoProject.Infra.Data.Configuration
{
	public class BoletoConfiguration : IEntityTypeConfiguration<Boleto>
	{
		public void Configure(EntityTypeBuilder<Boleto> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.NomePagador).HasMaxLength(255).IsRequired();
			builder.Property(x => x.CpfCnpjPagador).HasMaxLength(14).IsRequired();
			builder.Property(x => x.NomeBeneficiario).HasMaxLength(255).IsRequired();
			builder.Property(x => x.CpfCnpjBeneficiario).HasMaxLength(14).IsRequired();
			builder.Property(x => x.Valor).IsRequired();
			builder.Property(x => x.DataVencimento).IsRequired();
			builder.Property(x => x.Observacao).HasMaxLength(255);

			builder.HasOne(x => x.Banco)
				.WithMany(y => y.Boletos)
					.HasForeignKey(k => k.BancoId);
		}
	}
}
