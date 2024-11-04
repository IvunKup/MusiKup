using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class PlaylistFileValidator : AbstractValidator<PlaylistFile>
{
    public PlaylistFileValidator(string paramName)
    {
        Include(new BaseFileValidator(nameof(PlaylistFile)));
    }
}