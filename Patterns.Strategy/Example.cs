using Patterns.Strategy.Strategies;

namespace Patterns.Strategy;

internal class Example
{
    void Run()
    {
        var sorter = new Sorter<int>();

        sorter.SetSortingAlgorithm(new HeapSortAlgorithm<int>());
        sorter.Sort(new List<int> { 2, 1, 8, 5 });

        sorter.SetSortingAlgorithm(new MergeSortAlgorithm<int>());
        sorter.Sort(new List<int> { 2, 1, 8, 5 });

        sorter.SetSortingAlgorithm(new QuickSortAlgorithm<int>());
        sorter.Sort(new List<int> { 2, 1, 8, 5 });
    }
}
