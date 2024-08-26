using BoletoProject.Domain.Entities;
using BoletoProject.Domain.Validation.Errors;
using FluentValidation;

namespace BoletoProject.Domain.Validation
{
	public class BancoValidator : AbstractValidator<Banco>
	{
        public BancoValidator()
        {
			RuleFor(banco => banco)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required);

			RuleFor(x => x.NomeBanco)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required)
						.MaximumLength(128).WithMessage(GenericErrorsMessages.MustBeLessThan128);

			RuleFor(x => x.CodigoBanco)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required);

			RuleFor(x => x.PercentualJuros)
				.NotEmpty().WithMessage(GenericErrorsMessages.Required)
					.NotNull().WithMessage(GenericErrorsMessages.Required);

		}
    }
}
