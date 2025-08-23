namespace TechnologyPracticeTestWeb.Validators.Exceptions;

public class BlackListException : StringValidationException
{
    public BlackListException(string message) : base(message)
    {
    }
}