using TechnologyPracticeTest.StringModifiers.Implementations;
using TechnologyPracticeTest.StringModifiers.Implementations.TreeSort;
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
        
        Console.WriteLine("Выберите способ сортировки:");
        Console.WriteLine("1. Quick Sort");
        Console.WriteLine("2. Tree Sort");
        
        var choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
            {
                var quickSort = new StringQuickSorter();
                var sortedString = quickSort.Execute(reversedString);
                Console.WriteLine(sortedString);
                break;
            }
            case "2":
            {
                var treeSort = new StringTreeSorter();
                var sortedString = treeSort.Execute(reversedString);
                Console.WriteLine(sortedString);
                break;
            }
            default:
                Console.WriteLine("Неверный выбор сортировки.");
                break;
        }
        
        var randomCharRemover = new RandomCharRemover();
        Console.WriteLine(randomCharRemover.Execute(reversedString));
    }
}