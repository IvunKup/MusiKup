using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities;

namespace MusiKup.Domain.Validations.Validators;

public class TrackValidator : AbstractValidator<Track>
{
    public TrackValidator(string paramName)
    {
        RuleFor(param => param.Title)
            .NotNullOrEmptyWithMessage(nameof(Track.Title))
            .MaximumLength(200);
    }
}