using System.ComponentModel.DataAnnotations;
using TechnologyPracticeTestWeb.Validators.Exceptions;
using TechnologyPracticeTestWeb.Validators.Interfaces;

namespace TechnologyPracticeTestWeb.Validators.Implementations;

public class EnglishAlphabetValidator : ValidationAttribute, IStringValidator
{
    protected override ValidationResult IsValid(object input, ValidationContext context)
    {
        try
        {
            Validate(input as string);
            return ValidationResult.Success;
        }
        catch (StringValidationException e)
        {
            return new ValidationResult(e.Message);
        }
    }

    public void Validate(string input)
    {
        var invalidCharacters = input.Where(c => !(c >= 'a' && c <= 'z')).ToArray();

        if (invalidCharacters.Any())
        {
            throw new NotEnglishAlphabetException(
                $"Строка содержит недопустимые символы: {string.Join(", ", invalidCharacters)}");
        }
    }
}