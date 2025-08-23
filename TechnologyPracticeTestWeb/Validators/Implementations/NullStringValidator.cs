using TechnologyPracticeTestWeb.Validators.Exceptions;
using TechnologyPracticeTestWeb.Validators.Interfaces;

namespace TechnologyPracticeTestWeb.Validators.Implementations;

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