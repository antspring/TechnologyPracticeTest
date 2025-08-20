using TechnologyPracticeTest.validators.Implementations;
using TechnologyPracticeTest.validators.Interfaces;

namespace TechnologyPracticeTest;

public class StringReverser
{
    public List<IStringValidator> ValidationList { get; } = new()
    {
        new NullStringValidator(),
        new EnglishAlphabetValidator()
    };

    public string? Reverse(string? input)
    {
        foreach (var validator in ValidationList)
        {
            validator.Validate(input);
        }

        string result;

        if (input.Length % 2 == 0)
        {
            result = ReversEvenLengthString(input);
        }
        else
        {
            result = ReversOddLengthString(input);
        }

        return result;
    }

    private string ReversEvenLengthString(string input)
    {
        var substring = input[..(input.Length / 2)];
        var result = substring.Reverse();

        substring = input[(input.Length / 2)..];
        result = result.Concat(substring.Reverse());

        return new string(result.ToArray());
    }

    private string ReversOddLengthString(string input)
    {
        var result = new string(input.Reverse().ToArray()) + input;

        return result;
    }
}