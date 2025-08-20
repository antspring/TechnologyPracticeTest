using TechnologyPracticeTest.StringModifiers.Implementations;
using TechnologyPracticeTest.StringModifiers.Interfaces;
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


        var stringModifiers = new List<IStringModifier>
        {
            new StringReverser(),
            new CharacterCounter()
        };

        foreach (var modifier in stringModifiers)
        {
            Console.WriteLine(modifier.Execute(inputString));
        }
    }
}