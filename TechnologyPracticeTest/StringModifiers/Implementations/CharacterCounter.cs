using TechnologyPracticeTest.StringModifiers.Interfaces;

namespace TechnologyPracticeTest.StringModifiers.Implementations;

public class CharacterCounter : IStringModifier
{
    public string Execute(string input)
    {
        var characterCount = Count(input);
        var result = string.Join(", ", characterCount.Select(item => $"{item.Key}: {item.Value}"));
        return result;
    }

    public Dictionary<char, int> Count(string input)
    {
        var characterCount = new Dictionary<char, int>();

        foreach (var character in input)
        {
            if (characterCount.ContainsKey(character))
            {
                characterCount[character]++;
            }
            else
            {
                characterCount[character] = 1;
            }
        }

        return characterCount;
    }
}