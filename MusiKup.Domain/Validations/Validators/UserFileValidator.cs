using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class UserFileValidator : AbstractValidator<UserFile>
{
    public UserFileValidator(string paramName)
    {
        Include(new BaseFileValidator(nameof(UserFile)));
        RuleFor(param => param.UserId)
            .NotNullOrEmptyWithMessage(nameof(UserFile));
    }
}