namespace Patterns.Strategy.Strategies;

internal class QuickSortAlgorithm<T> : ISortingAlgorithm<T>
{
    private readonly IComparer<T> _comparer = Comparer<T>.Default;

    public IList<T> Sort(IList<T> values)
    {
        return QuickSort(values, 0, values.Count - 1);
    }

    private IList<T> QuickSort(IList<T> array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);

            QuickSort(array, low, partitionIndex - 1);
            QuickSort(array, partitionIndex + 1, high);
        }

        return array;
    }

    private int Partition(IList<T> array, int low, int high)
    {
        var pivot = array[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
        {
            if (_comparer.Compare(array[j], pivot) < 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private void Swap(IList<T> array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
