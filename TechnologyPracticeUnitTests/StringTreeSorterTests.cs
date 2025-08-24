using TechnologyPracticeTest.StringModifiers.Implementations.TreeSort;

namespace TechnologyPracticeUnitTests;

public class StringTreeSorterTests
{
    private StringTreeSorter _sorter;

    [SetUp]
    public void Setup()
    {
        _sorter = new StringTreeSorter();
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