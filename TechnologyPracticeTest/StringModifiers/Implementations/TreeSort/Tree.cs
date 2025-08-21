using TechnologyPracticeTest.StringModifiers.Implementations.TreeSort.TreeVisitors.Interfaces;

namespace TechnologyPracticeTest.StringModifiers.Implementations.TreeSort;

public class Tree<T> where T : IComparable<T>
{
    public Tree<T>? Left { get; private set; }
    public Tree<T>? Right { get; private set; }
    public T Value { get; }

    public Tree(T value)
    {
        Value = value;
    }

    public void Insert(Tree<T> tree)
    {
        if (tree.Value.CompareTo(Value) < 0)
        {
            if (Left == null) Left = tree;
            else Left.Insert(tree);
        }
        else
        {
            if (Right == null) Right = tree;
            else Right.Insert(tree);
        }
    }

    public void Traversal(ITreeVisitor<T> visitor)
    {
        Left?.Traversal(visitor);
        visitor.Traversal(this);
        Right?.Traversal(visitor);
    }
}