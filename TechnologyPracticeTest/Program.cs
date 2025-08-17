namespace TechnologyPracticeTest;
class Program
{
    static void Main(string[] args)
    {
        var inputString = Console.ReadLine();

        var stringReverser = new StringReverser();

        Console.WriteLine(stringReverser.Reverse(inputString));
    }
}
