using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class PerformerFileValidator : AbstractValidator<PerformerFile>
{
    public PerformerFileValidator(string paramName)
    {
        Include(new BaseFileValidator(nameof(PerformerFile)));
    }
}