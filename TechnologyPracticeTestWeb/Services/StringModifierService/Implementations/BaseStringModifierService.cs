using TechnologyPracticeTestWeb.Requests.ModifyStringRequest;
using TechnologyPracticeTestWeb.Services.StringModifierService.Interfaces;
using TechnologyPracticeTestWeb.StringModifiers.Implementations;
using TechnologyPracticeTestWeb.StringModifiers.Implementations.TreeSort;

namespace TechnologyPracticeTestWeb.Services.StringModifierService.Implementations;

public class BaseStringModifierService : IStringModifierService
{
    private readonly IConfiguration _configuration;

    public BaseStringModifierService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Dictionary<string, string> Modify(ModifyStringRequest request)
    {
        var reversedString = new StringReverser().Execute(request.Input);
        var sortedString = ExecuteSort(reversedString, request.SortType);

        return new Dictionary<string, string>
        {
            { "reversed", reversedString },
            { "characters", new CharacterCounter().Execute(reversedString) },
            { "substring", new BiggestSubstring().Execute(reversedString) },
            { "sorted", sortedString },
            { "truncated", new RandomCharRemover(_configuration.GetValue<string>("RandomApi")).Execute(reversedString) }
        };
    }

    private string ExecuteSort(string input, StringSortType sortType)
    {
        return sortType switch
        {
            StringSortType.QuickSort => new StringQuickSorter().Execute(input),
            StringSortType.TreeSort => new StringTreeSorter().Execute(input),
            _ => input
        };
    }
}