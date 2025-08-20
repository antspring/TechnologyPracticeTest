namespace TechnologyPracticeTest.Validators.Exceptions;

public class NotEnglishAlphabetException : StringValidationException
{
    public NotEnglishAlphabetException(string message) : base(message)
    {
    }
}