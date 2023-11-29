using Patterns.Strategy.Strategies;

namespace Patterns.Strategy;

internal class Sorter<T>
{
    private ISortingAlgorithm<T> _sortingAlgorithm;

    public void SetSortingAlgorithm(ISortingAlgorithm<T> sortingAlgorithm)
    {
        _sortingAlgorithm = sortingAlgorithm;
    }

    public IList<T> Sort(IList<T> values)
    {
        _sortingAlgorithm ??= new QuickSortAlgorithm<T>();

        return _sortingAlgorithm.Sort(values);
    }
}
