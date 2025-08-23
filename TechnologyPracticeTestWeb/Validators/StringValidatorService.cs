using TechnologyPracticeTestWeb.Validators.Interfaces;

namespace TechnologyPracticeTestWeb.Validators;

public class StringValidatorService
{
    private readonly IEnumerable<IStringValidator> _validators;

    public StringValidatorService(IEnumerable<IStringValidator> validators)
    {
        _validators = validators;
    }

    public void Validate(string input)
    {
        foreach (var validator in _validators)
        {
            validator.Validate(input);
        }
    }
}