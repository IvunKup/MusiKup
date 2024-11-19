using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities;
using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Validations.Validators;

public class TrackValidator : AbstractValidator<Track>
{
    public TrackValidator(string paramName)
    {
        RuleFor(param => param.Title)
            .NotNullOrEmptyWithMessage(nameof(Track.Title))
            .MaximumLength(200).WithMessage(ExceptionMessages.InvalidLengh(nameof(Track.Title)));
    }
}