using System.Text.Json;
using TechnologyPracticeTestWeb.StringModifiers.Interfaces;

namespace TechnologyPracticeTestWeb.StringModifiers.Implementations;

public class RandomCharRemover : IStringModifier
{
    public string Execute(string input)
    {
        var randomIndex = GetRandomIndexAsync(input.Length).GetAwaiter().GetResult();

        return input.Remove(randomIndex, 1);
    }

    private async Task<int> GetRandomIndexAsync(int stringLength)
    {
        using var client = new HttpClient { BaseAddress = new Uri("http://www.randomnumberapi.com/api/v1.0") };

        var response = await client.GetAsync($"/api/v1.0/randomnumber?max={stringLength - 1}");

        if (response.IsSuccessStatusCode)
        {
            return await ParseIndexFromResponse(response);
        }

        return GetRandomIndex(stringLength);
    }

    private async Task<int> ParseIndexFromResponse(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<int[]>(content)[0];
    }

    private int GetRandomIndex(int stringLength)
    {
        var random = new Random();
        return random.Next(stringLength);
    }
}