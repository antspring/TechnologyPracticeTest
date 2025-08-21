using System.Text;
using TechnologyPracticeTest.StringModifiers.Implementations.TreeSort.TreeVisitors.Interfaces;

namespace TechnologyPracticeTest.StringModifiers.Implementations.TreeSort.TreeVisitors.Implementations;

public class SortVisitor : ITreeVisitor<string>
{
    public StringBuilder SortedStringBuilder { get; } = new();

    public void Traversal(Tree<string> tree)
    {
        SortedStringBuilder.Append(tree.Value);
    }
}