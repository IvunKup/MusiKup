using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities;
using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Validations.Validators;

public class PlaylistValidator : AbstractValidator<Playlist>
{
    public PlaylistValidator(string paramName)
    {
        RuleFor(param => param.Title)
            .NotNullOrEmptyWithMessage(nameof(Playlist.Title))
            .Length(1, 100).WithMessage(ExceptionMessages.InvalidLength(nameof(Playlist.Title)));
        RuleFor(param => param.Description)
            .NotNullOrEmptyWithMessage(nameof(Playlist.Description))
            .Length(1, 1000).WithMessage(ExceptionMessages.InvalidLength(nameof(Playlist.Description)));
    }
}