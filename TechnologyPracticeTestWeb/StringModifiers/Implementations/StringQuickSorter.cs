using TechnologyPracticeTestWeb.StringModifiers.Interfaces;

namespace TechnologyPracticeTestWeb.StringModifiers.Implementations;

public class StringQuickSorter : IStringModifier
{
    public string Execute(string input)
    {
        var characters = input.ToCharArray();

        QuickSort(characters, 0, characters.Length - 1);

        return new string(characters);
    }

    public void QuickSort(char[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    private int Partition(char[] array, int left, int right)
    {
        var pivot = array[right];
        var i = left - 1;

        for (var j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);

        return i + 1;
    }
}