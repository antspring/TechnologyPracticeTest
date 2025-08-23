using System.ComponentModel.DataAnnotations;
using TechnologyPracticeTestWeb.Validators.Implementations;

namespace TechnologyPracticeTestWeb.Requests.ModifyStringRequest;

public class ModifyStringRequest
{
    [Required]
    [EnglishAlphabetValidator]
    public string Input { get; set; }
    
    [Required]
    public StringSortType SortType { get; set; }
}