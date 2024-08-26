using BoletoProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoletoProject.Infra.Data.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		private DbSet<Banco> Bancos { get; set; }
		private DbSet<Boleto> Boleto { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}
	}

}
