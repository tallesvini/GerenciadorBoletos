using AutoMapper;
using BoletoProject.Application.CQRS.Bancos.Commands;
using BoletoProject.Application.CQRS.Boletos.Commands;
using BoletoProject.Application.DTOs;

namespace BoletoProject.Application.Mappings
{
	public class DTOToCommandMappingProfile : Profile
	{
        public DTOToCommandMappingProfile()
        {
            CreateMap<BoletoDTO, BoletoCreateCommand>();
            CreateMap<BoletoCreatedDTO, BoletoCreateCommand>();
            CreateMap<BancoDTO, BancoCreateCommand>();
            CreateMap<BancoCreatedDTO, BancoCreateCommand>();
        }
    }
}
