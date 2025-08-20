using TechnologyPracticeTest.StringModifiers.Interfaces;

namespace TechnologyPracticeTest.StringModifiers.Implementations;

public class BiggestSubstring : IStringModifier
{
    private const string Vowels = "aeiouy";

    public string Execute(string input)
    {
        return GetSubstring(input);
    }

    public string GetSubstring(string input)
    {
        int startIndex = 0, endIndex = 0;
        var isFirstVowelFound = false;

        for (var i = 0; i < input.Length; i++)
        {
            if (Vowels.Contains(input[i]))
            {
                if (!isFirstVowelFound)
                {
                    startIndex = i;
                    isFirstVowelFound = true;
                }

                endIndex = i;
            }
        }
        
        if (!isFirstVowelFound)
        {
            return string.Empty;
        }

        return input.Substring(startIndex, endIndex - startIndex + 1);
    }
}