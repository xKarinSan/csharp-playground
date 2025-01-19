using csharp_playground.utilities.interfaces;
using static csharp_playground.utilities.Utilities;
namespace csharp_playground.sortingalgos;

class SortingTest : ITest
{
    int[] _quickSortArr;
    InsertionSort _quicksort;
    public SortingTest()
    {
        _quickSortArr = GenerateRandomArray(15, 0, 1000);
        _quicksort = new(_quickSortArr);
    }
    public void RunTest()
    {
        Console.WriteLine("Quick Sort....");
        _quicksort.DisplayContents();
        _quicksort.TriggerSorting();
        _quicksort.DisplayContents();
        Console.WriteLine("Quick Sort done!....");

    }

}