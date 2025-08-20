using TechnologyPracticeTest.Validators.Exceptions;
using TechnologyPracticeTest.validators.Interfaces;

namespace TechnologyPracticeTest.validators.Implementations;

public class NullStringValidator : IStringValidator
{
    public void Validate(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new NullStringException("Строка не может быть пустой или равной null.");
        }
    }
}