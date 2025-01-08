using csharp_playground.utilities.interfaces;
namespace csharp_playground.datastructures.Arrays;
class FixedArrayTest : ITest
{
    FixedArray fixedArray;
    public FixedArrayTest()
    { fixedArray = new FixedArray(3, "int"); }

    public void RunTest()
    {
        // Add valid items to the FixedArray
        Console.WriteLine("Adding valid items to the FixedArray:");
        fixedArray.AddItem(new FixedArrayItem(42, "int"));
        fixedArray.AddItem(new FixedArrayItem(27, "int"));
        fixedArray.AddItem(new FixedArrayItem(99, "int"));

        // Attempt to add an invalid item of a different data type
        Console.WriteLine("\nTrying to add an invalid item (type mismatch):");
        fixedArray.AddItem(new FixedArrayItem("Hello", "string")); // This won't be added.

        // Traverse and display the FixedArray
        Console.WriteLine("\nTraversing the FixedArray:");
        fixedArray.TraverseArray();

        // Retrieve an item by index
        Console.WriteLine("\nRetrieving item at index 1:");
        var item = fixedArray.GetItemByIndex(1);
        if (item != null)
        {
            Console.WriteLine($"Retrieved Item: {item.Value}, DataType: {item.DataType}");
        }
        else
        {
            Console.WriteLine("No item found at the specified index.");
        }

        // Remove an item by index
        Console.WriteLine("\nRemoving item at index 1:");
        fixedArray.RemoveItemAtIndex(1);

        // Traverse and display the FixedArray again
        Console.WriteLine("\nTraversing the FixedArray after removal:");
        fixedArray.TraverseArray();

        // Try to retrieve an item from an invalid index
        Console.WriteLine("\nRetrieving item at an invalid index (5):");
        var invalidItem = fixedArray.GetItemByIndex(5);
        if (invalidItem == null)
        {
            Console.WriteLine("Invalid index. No item found.");
        }
    }
}