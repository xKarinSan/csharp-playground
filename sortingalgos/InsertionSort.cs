namespace csharp_playground.sortingalgos;
class InsertionSort : ISorting
{
    int[] _arr;
    public int[] Arr
    {
        get => _arr;
        set => _arr = value;
    }

    public InsertionSort(int[] arr)
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
        // bottom is always sorted
        for (int i = 1; i < _arr.Length; i++)
        {
            int temp = Arr[i];
            int j = i - 1;
            while (j >= 0 && temp < Arr[j])
            {
                Arr[j + 1] = Arr[j];
                j--;
            }
            Arr[j + 1] = temp;
        }
        Console.WriteLine("Sorting done!");
    }
}