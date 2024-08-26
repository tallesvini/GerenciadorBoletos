using AutoMapper;
using BoletoProject.Application.CQRS.Bancos.Commands;
using BoletoProject.Application.CQRS.Boletos.Commands;
using BoletoProject.Domain.Entities;

namespace BoletoProject.Application.Mappings
{
	public class CommandToDomainMappingProfile : Profile
	{
        public CommandToDomainMappingProfile()
        {
            CreateMap<BoletoCreateCommand, Boleto>();
            CreateMap<BancoCreateCommand, Banco>();
        }
    }
}
