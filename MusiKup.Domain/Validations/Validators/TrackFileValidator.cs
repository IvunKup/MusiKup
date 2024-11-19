using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class TrackFileValidator : AbstractValidator<TrackFile>
{
    public TrackFileValidator(string paramName)
    {
        Include(new BaseFileValidator(nameof(TrackFile)));
        RuleFor(param => param.TrackId)
            .NotNullOrEmptyWithMessage(nameof(TrackFile));
    }
}