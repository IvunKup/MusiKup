using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities;
using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Validations.Validators;

public class AuthorValidator : AbstractValidator<Author>
{
    public AuthorValidator(string paramName)
    {
        RuleFor(param => param.NickName)
            .NotNullOrEmptyWithMessage(nameof(Author.NickName))
            .Length(1, 100).WithMessage(ExceptionMessages.InvalidLengh(nameof(Author.NickName)));
        RuleFor(param => param.FullName)
            .SetValidator(new FullNameValidator(nameof(Author.FullName)));
    }
}