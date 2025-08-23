using TechnologyPracticeTestWeb.StringModifiers.Implementations.TreeSort.TreeVisitors.Implementations;
using TechnologyPracticeTestWeb.StringModifiers.Interfaces;

namespace TechnologyPracticeTestWeb.StringModifiers.Implementations.TreeSort;

public class StringTreeSorter : IStringModifier
{
    public string Execute(string input)
    {
        var tree = BuildTree(input);
        return GetSortedString(tree);
    }

    private Tree<string> BuildTree(string input)
    {
        var tree = new Tree<string>(input[0].ToString());

        for (var i = 1; i < input.Length; i++)
        {
            tree.Insert(new Tree<string>(input[i].ToString()));
        }

        return tree;
    }

    private string GetSortedString(Tree<string> tree)
    {
        var visitor = new SortVisitor();
        tree.Traversal(visitor);
        return visitor.SortedStringBuilder.ToString();
    }
}