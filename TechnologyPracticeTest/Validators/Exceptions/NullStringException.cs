namespace TechnologyPracticeTest.Validators.Exceptions;

public class NullStringException : StringValidationException
{
    public NullStringException(string message) : base(message)
    {
    }
}