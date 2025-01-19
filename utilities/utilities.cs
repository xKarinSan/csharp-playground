namespace csharp_playground.utilities;
public static class Utilities
{
    public static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        Random random = new();
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = random.Next(minValue, maxValue + 1);
        }
        return randomArray;
    }
}