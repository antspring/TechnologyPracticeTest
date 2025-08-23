using System.Text;
using TechnologyPracticeTestWeb.StringModifiers.Implementations.TreeSort.TreeVisitors.Interfaces;

namespace TechnologyPracticeTestWeb.StringModifiers.Implementations.TreeSort.TreeVisitors.Implementations;

public class SortVisitor : ITreeVisitor<string>
{
    public StringBuilder SortedStringBuilder { get; } = new();

    public void Traversal(Tree<string> tree)
    {
        SortedStringBuilder.Append(tree.Value);
    }
}