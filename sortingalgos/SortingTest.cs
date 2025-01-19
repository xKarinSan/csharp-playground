using csharp_playground.utilities.interfaces;
using static csharp_playground.utilities.Utilities;
namespace csharp_playground.sortingalgos;

class SortingTest : ITest
{
    int[] _insertionSortArr;
    InsertionSort _insertionsort;

    int[] _quickSortArr;
    QuickSort _quickSort;
    public SortingTest()
    {
        _insertionSortArr = GenerateRandomArray(15, 0, 1000);
        _insertionsort = new(_insertionSortArr);

        _quickSortArr = GenerateRandomArray(15, 0, 1000);
        _quickSort = new(_quickSortArr);
    }
    public void RunTest()
    {
        Console.WriteLine("Insertion Sort....");
        _insertionsort.DisplayContents();
        _insertionsort.TriggerSorting();
        _insertionsort.DisplayContents();
        Console.WriteLine("Insertion Sort done!....");

        Console.WriteLine("Quick Sort....");
        _quickSort.DisplayContents();
        _quickSort.TriggerSorting();
        _quickSort.DisplayContents();
        Console.WriteLine("Quick Sort done!....");
    }

}