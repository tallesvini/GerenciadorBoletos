using AutoMapper;
using BoletoProject.Application.DTOs;
using BoletoProject.Domain.Entities;

namespace BoletoProject.Application.Mappings
{
	public class DomainToDTOMappingProfile : Profile
	{
		public DomainToDTOMappingProfile()
		{
			CreateMap<Boleto, BoletoDTO>().ReverseMap();
			CreateMap<Boleto, BoletoFkDTO>().ReverseMap();
			CreateMap<Banco, BancoDTO>().ReverseMap();
			CreateMap<Banco, BancoFkDTO>().ReverseMap();
		}
	}
}
