using TechnologyPracticeTestWeb.Requests.ModifyStringRequest;

namespace TechnologyPracticeTestWeb.Services.StringModifierService.Interfaces;

public interface IStringModifierService
{
    public Dictionary<string, string> Modify(ModifyStringRequest request);
}