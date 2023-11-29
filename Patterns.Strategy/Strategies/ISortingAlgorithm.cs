namespace Patterns.Strategy.Strategies;

internal interface ISortingAlgorithm<T>
{
    IList<T> Sort(IList<T> values);
}
