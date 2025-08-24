using TechnologyPracticeTest.StringModifiers.Implementations;

namespace TechnologyPracticeUnitTests;

public class StringQuickSorterTests
{
    private StringQuickSorter _sorter;

    [SetUp]
    public void Setup()
    {
        _sorter = new StringQuickSorter();
    }

    [TestCase("dcba", "abcd")]
    [TestCase("hello", "ehllo")]
    [TestCase("321", "123")]
    public void Test(string input, string expected)
    {
        var result = _sorter.Execute(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}