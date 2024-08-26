using AutoMapper;
using BoletoProject.Application.CQRS.Bancos.Commands;
using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace BoletoProject.Application.CQRS.Bancos.Handlers
{
	public class BancoCreateCommandHandler : IRequestHandler<BancoCreateCommand, Banco>
	{
		private readonly IBancoRepository _bancoRepository;
		private readonly IValidator<Banco> _validator;
		private readonly IMapper _mapper;

		public BancoCreateCommandHandler(IBancoRepository bancoRepository, IValidator<Banco> validator, IMapper mapper)
		{
			_bancoRepository = bancoRepository;
			_validator = validator;
			_mapper = mapper;
		}

		public async Task<Banco> Handle(BancoCreateCommand request, CancellationToken cancellationToken)
		{
			Banco banco = _mapper.Map<Banco>(request);

			ValidationResult validationResults = _validator.Validate(banco);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);

			await _bancoRepository.AddEntityAsync(banco);

			return banco;
		}
	}
}
