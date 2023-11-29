namespace Patterns.Strategy.Strategies;

internal class MergeSortAlgorithm<T> : ISortingAlgorithm<T>
{
    private readonly IComparer<T> _comparer = Comparer<T>.Default;

    public IList<T> Sort(IList<T> values)
    {
        return MergeSort(values);
    }

    private IList<T> MergeSort(IList<T> list)
    {
        if (list.Count <= 1)
            return list;

        int middle = list.Count / 2;

        var left = new List<T>(list.Take(middle)) as IList<T>;
        var right = new List<T>(list.Skip(middle)) as IList<T>;

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    private List<T> Merge(IList<T> left, IList<T> right)
    {
        var result = new List<T>();

        int i = 0, j = 0;

        while (i < left.Count && j < right.Count)
        {
            if (_comparer.Compare(left[i], right[j]) < 0)
            {
                result.Add(left[i++]);
            }
            else
            {
                result.Add(right[j++]);
            }
        }

        while (i < left.Count)
        {
            result.Add(left[i++]);
        }

        while (j < right.Count)
        {
            result.Add(right[j++]);
        }

        return result;
    }
}
