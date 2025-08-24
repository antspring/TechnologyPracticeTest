using TechnologyPracticeTest.StringModifiers.Implementations;

namespace TechnologyPracticeUnitTests;

public class CharacterCounterTests
{
    private CharacterCounter _characterCounter;

    [SetUp]
    public void Setup()
    {
        _characterCounter = new CharacterCounter();
    }

    [Test]
    public void Count_ValidInput_ReturnsDictionary()
    {
        var input = "hello";
        var expected = new Dictionary<char, int>
        {
            { 'h', 1 },
            { 'e', 1 },
            { 'l', 2 },
            { 'o', 1 }
        };
        
        var result = _characterCounter.Count(input);
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Execute_ValidInput_ReturnsFormattedString()
    {
        var input = "hello";
        var expected = "h: 1, e: 1, l: 2, o: 1";
        
        var result = _characterCounter.Execute(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}