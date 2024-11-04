using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class AuthorFileValidator : AbstractValidator<AuthorFile>
{
    public AuthorFileValidator(string paramName)
    {
        Include(new BaseFileValidator(nameof(AuthorFile)));
    }
}