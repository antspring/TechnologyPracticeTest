using TechnologyPracticeTest.Validators.Exceptions;
using TechnologyPracticeTest.validators.Interfaces;

namespace TechnologyPracticeTest.validators.Implementations;

public class EnglishAlphabetValidator : IStringValidator
{
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