namespace TechnologyPracticeTestWeb.StringModifiers.Implementations.TreeSort.TreeVisitors.Interfaces;

public interface ITreeVisitor<T> where T : IComparable<T>
{
    public void Traversal(Tree<T> tree);
}