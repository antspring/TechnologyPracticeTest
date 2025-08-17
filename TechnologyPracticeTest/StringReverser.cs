namespace TechnologyPracticeTest;

public class StringReverser
{
    public string? Reverse(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
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