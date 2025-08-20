using TechnologyPracticeTest.StringModifiers.Implementations;
using TechnologyPracticeTest.Validators;
using TechnologyPracticeTest.Validators.Exceptions;
using TechnologyPracticeTest.validators.Implementations;
using TechnologyPracticeTest.validators.Interfaces;

namespace TechnologyPracticeTest;

class Program
{
    static void Main(string[] args)
    {
        var inputString = Console.ReadLine();

        try
        {
            var validators = new List<IStringValidator>
            {
                new NullStringValidator(),
                new EnglishAlphabetValidator()
            };

            var stringValidatorService =
                new StringValidatorService(validators);

            stringValidatorService.Validate(inputString);
        }
        catch (StringValidationException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        var stringReverser = new StringReverser();
        var reversedString = stringReverser.Execute(inputString);
        Console.WriteLine(reversedString);

        var characterCounter = new CharacterCounter();
        Console.WriteLine(characterCounter.Execute(inputString));

        var biggestSubstring = new BiggestSubstring();
        Console.WriteLine(biggestSubstring.Execute(reversedString));
    }
}