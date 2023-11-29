namespace Patterns.Strategy.Strategies;

internal class HeapSortAlgorithm<T> : ISortingAlgorithm<T>
{
    private readonly IComparer<T> _comparer = Comparer<T>.Default;

    public IList<T> Sort(IList<T> values)
    {
        return HeapSort(values);
    }

    private IList<T> HeapSort(IList<T> list)
    {
        int n = list.Count;

        // Build heap (rearrange list)
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(list, n, i);
        }

        // One by one extract an element from the heap
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            Swap(list, 0, i);

            // Call max heapify on the reduced heap
            Heapify(list, i, 0);
        }

        return list;
    }

    private void Heapify(IList<T> list, int n, int i)
    {
        int largest = i;  // Initialize largest as root
        int left = 2 * i + 1;  // Left child
        int right = 2 * i + 2;  // Right child

        // If left child is larger than root
        if (left < n && _comparer.Compare(list[left], list[largest]) > 0)
        {
            largest = left;
        }

        // If right child is larger than largest so far
        if (right < n && _comparer.Compare(list[right], list[largest]) > 0)
        {
            largest = right;
        }

        // If largest is not root
        if (largest != i)
        {
            Swap(list, i, largest);

            // Recursively heapify the affected sub-tree
            Heapify(list, n, largest);
        }
    }

    private void Swap(IList<T> list, int i, int j)
    {
        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
