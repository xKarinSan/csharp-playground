namespace csharp_playground.sortingalgos;
class QuickSort : ISorting
{
    int[] _arr;
    public int[] Arr
    {
        get => _arr;
        set => _arr = value;
    }

    public QuickSort(int[] arr)
    {
        Arr = arr;
    }

    public void DisplayContents()
    {
        Console.WriteLine("Displaying ....");
        foreach (int i in Arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Displayed ....");

    }
    public void TriggerSorting()
    {
        QuickSortHelper(0, Arr.Length - 1);
    }

    public void QuickSortHelper(int startIdx, int endIdx)
    {
        // let the mid point be pivot.
        // if start > end, end
        if (startIdx > endIdx) return;

        int pivotIdx = GetPivot(startIdx, endIdx);
        // left subarr
        QuickSortHelper(startIdx, pivotIdx - 1);
        // right subarr
        QuickSortHelper(pivotIdx + 1, endIdx);
    }

    public int GetPivot(int startIdx, int endIdx)
    {

        int pivotVal = Arr[endIdx];
        int i = startIdx - 1;
        for (int j = startIdx; j < endIdx; j++)
        {
            if (Arr[j] <= pivotVal)
            {
                i++;
                (Arr[i], Arr[j]) = (Arr[j], Arr[i]);
            }
        }
        (Arr[i + 1], Arr[endIdx]) = (Arr[endIdx], Arr[i + 1]);
        return i + 1;
    }
}