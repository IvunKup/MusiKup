using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities;

namespace MusiKup.Domain.Validations.Validators;

public class AuthorValidator : AbstractValidator<Author>
{
    public AuthorValidator(string paramName)
    {
        RuleFor(param => param.NickName)
            .NotNullOrEmptyWithMessage(nameof(Author.NickName))
            .Length(1, 100);
    }
}