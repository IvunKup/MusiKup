using Domain.Validations;
using FluentValidation;
using MusiKup.Domain.Entities.Files;

//TODO: Дописать Must и сделать оставшиеся валидаторы для файлов.

namespace MusiKup.Domain.Validations.Validators;

public class BaseFileValidator : AbstractValidator<BaseFile>
{
    public BaseFileValidator(string paramName)
    {
        RuleFor(param => param.FileName)
            .NotNullOrEmptyWithMessage(nameof(BaseFile.FileName))
            .Length(1, 100);
        RuleFor(param => param.FilePath)
            .NotNullOrEmptyWithMessage(nameof(BaseFile.FilePath))
            .Must(Path.IsPathFullyQualified);
    }
}