using TechnologyPracticeTest.StringModifiers.Implementations;

namespace TechnologyPracticeUnitTests;

public class StringReverserTests
{
    private StringReverser _reverser;

    [SetUp]
    public void Setup()
    {
        _reverser = new StringReverser();
    }

    [TestCase("abcd", "badc")]
    [TestCase("abcde", "edcbaabcde")]
    [TestCase("", "")]
    [TestCase("a", "aa")]
    [TestCase("абвгд", "дгвбаабвгд")]
    public void Test(string input, string expected)
    {
        var result = _reverser.Reverse(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}