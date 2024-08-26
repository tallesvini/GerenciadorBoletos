using MediatR;
using BoletoProject.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BoletoProject.Application.Mappings;
using BoletoProject.Domain.Interfaces;
using BoletoProject.Infra.Data.Repositories;
using BoletoProject.Application.Interfaces;
using BoletoProject.Application.Services;
using FluentValidation;
using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Validation;
using FluentValidation.AspNetCore;

namespace BoletoProject.Infra.IoC
{
	public static class Injections
	{
		public static IServiceCollection AddDbConnection(
			this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(options =>
				options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

			return services;
		}

		public static IServiceCollection AddDependencies(this IServiceCollection services)
		{
			var handles = AppDomain.CurrentDomain.Load("BoletoProject.Application");
			services.AddMediatR(handles);

			services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
			services.AddAutoMapper(typeof(CommandToDomainMappingProfile));

			return services;
		}

		public static IServiceCollection AddInfrastructure(this IServiceCollection services)
		{
			services.AddScoped<IBancoRepository, BancoRepository>();
			services.AddScoped<IBoletoRepository, BoletoRepository>();
			services.AddScoped<IBoletoService, BoletoService>();
			services.AddScoped<IBancoService, BancoService>();

			return services;
		}

		public static IServiceCollection AddValidation(this IServiceCollection services)
		{
			services.AddFluentValidationAutoValidation();
			services.AddTransient<IValidator<Banco>, BancoValidator>();
			services.AddTransient<IValidator<Boleto>, BoletoValidator>();

			return services;
		}
	}
}
