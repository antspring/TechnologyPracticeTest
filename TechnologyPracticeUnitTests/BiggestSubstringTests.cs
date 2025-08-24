using TechnologyPracticeTest.StringModifiers.Implementations;

namespace TechnologyPracticeUnitTests;

public class BiggestSubstringTests
{
    private BiggestSubstring _biggestSubstring;

    [SetUp]
    public void Setup()
    {
        _biggestSubstring = new BiggestSubstring();
    }

    [TestCase("abcabcbb", "abca")]
    [TestCase("bbbbb", "")]
    [TestCase("pwwkew", "e")]
    [TestCase("aeiouy", "aeiouy")]
    public void Test(string input, string expected)
    {
        var result = _biggestSubstring.Execute(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}