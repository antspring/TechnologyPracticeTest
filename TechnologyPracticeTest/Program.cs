using TechnologyPracticeTest.Validators.Exceptions;

namespace TechnologyPracticeTest;

class Program
{
    static void Main(string[] args)
    {
        var inputString = Console.ReadLine();

        var stringReverser = new StringReverser();

        try
        {
            Console.WriteLine(stringReverser.Reverse(inputString));
        }
        catch (StringValidationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}