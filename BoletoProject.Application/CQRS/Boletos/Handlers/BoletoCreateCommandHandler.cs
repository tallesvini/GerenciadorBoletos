using AutoMapper;
using BoletoProject.Application.CQRS.Boletos.Commands;
using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace BoletoProject.Application.CQRS.Boletos.Handlers
{
	public class BoletoCreateCommandHandler : IRequestHandler<BoletoCreateCommand, Boleto>
	{
		private readonly IBoletoRepository _boletoRepository;
		private readonly IMapper _mapper;
		private readonly IValidator<Boleto> _validator;

		public BoletoCreateCommandHandler(IBoletoRepository boletoRepository, IMapper mapper, IValidator<Boleto> validator)
		{
			_boletoRepository = boletoRepository;
			_mapper = mapper;
			_validator = validator;
		}

		public async Task<Boleto> Handle(BoletoCreateCommand request, CancellationToken cancellationToken)
		{
			Boleto boleto = _mapper.Map<Boleto>(request);

			ValidationResult validationResults = _validator.Validate(boleto);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);

			await _boletoRepository.AddEntityAsync(boleto);
			return boleto;
		}
	}
}
