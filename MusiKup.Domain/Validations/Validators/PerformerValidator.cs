using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities;

namespace MusiKup.Domain.Validations.Validators;

public class PerformerValidator : AbstractValidator<Performer>
{
    public PerformerValidator(string paramName)
    {
        RuleFor(param => param.NickName)
            .NotNullOrEmptyWithMessage(nameof(Performer.NickName))
            .Length(1, 100);
    }
}