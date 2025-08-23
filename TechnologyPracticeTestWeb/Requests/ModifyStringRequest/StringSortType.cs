using System.Text.Json.Serialization;

namespace TechnologyPracticeTestWeb.Requests.ModifyStringRequest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StringSortType
{
    QuickSort,
    TreeSort,
}