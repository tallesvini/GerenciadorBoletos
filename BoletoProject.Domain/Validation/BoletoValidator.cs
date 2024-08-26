using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Validation.Errors;
using FluentValidation;

namespace BoletoProject.Domain.Validation
{
	public class BoletoValidator : AbstractValidator<Boleto>
	{
        public BoletoValidator()
        {
			RuleFor(boleto => boleto)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required);

			RuleFor(x => x.NomePagador)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required)
						.MaximumLength(255).WithMessage(GenericErrorsMessages.MustBeLessThan255);

			RuleFor(x => x.CpfCnpjPagador)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required)
						.MaximumLength(14).WithMessage(GenericErrorsMessages.MustBeLessThan14);

			RuleFor(x => x.NomeBeneficiario)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required)
						.MaximumLength(255).WithMessage(GenericErrorsMessages.MustBeLessThan255);

			RuleFor(x => x.CpfCnpjBeneficiario)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required)
						.MaximumLength(14).WithMessage(GenericErrorsMessages.MustBeLessThan14);

			RuleFor(x => x.Valor)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required);

			RuleFor(x => x.DataVencimento)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required);

			RuleFor(x => x.Observacao)
				.MaximumLength(255).WithMessage(GenericErrorsMessages.MustBeLessThan14);
		}
    }
}
