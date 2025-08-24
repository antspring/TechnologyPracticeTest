using TechnologyPracticeTest.Validators.Exceptions;
using TechnologyPracticeTest.validators.Implementations;

namespace TechnologyPracticeUnitTests;

public class EnglishAlphabetValidatorTests
{
    private EnglishAlphabetValidator _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new EnglishAlphabetValidator();
    }

    [TestCase("abcd")]
    [TestCase("xyz")]
    [TestCase("hello")]
    public void Test(string input)
    {
        Assert.DoesNotThrow(() => _validator.Validate(input));
    }

    [TestCase("abc1")]
    [TestCase("дфлывдл")]
    [TestCase("';234-23-=")]
    public void InvalidCharactersTest(string input)
    {
        Assert.Throws<NotEnglishAlphabetException>(() => _validator.Validate(input));
    }
}