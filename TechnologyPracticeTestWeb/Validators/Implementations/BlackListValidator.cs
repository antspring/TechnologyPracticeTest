using System.ComponentModel.DataAnnotations;
using TechnologyPracticeTestWeb.Validators.Exceptions;
using TechnologyPracticeTestWeb.Validators.Interfaces;

namespace TechnologyPracticeTestWeb.Validators.Implementations;

public class BlackListValidator : ValidationAttribute, IStringValidator
{
    private List<string> _blackList;

    protected override ValidationResult IsValid(object input, ValidationContext context)
    {
        try
        {
            var config = (IConfiguration)context.GetService(typeof(IConfiguration));
            _blackList = GetBlackList(config);
            Validate(input as string);
            return ValidationResult.Success;
        }
        catch (StringValidationException e)
        {
            return new ValidationResult(e.Message);
        }
    }

    public void Validate(string input)
    {
        if (_blackList.Any(word => input.Contains(word)))
        {
            throw new BlackListException("Строка содержит запрещённые слова");
        }
    }

    private List<string> GetBlackList(IConfiguration config)
    {
        return config.GetSection("BlackList").Get<List<string>>() ?? new List<string>();
    }
}