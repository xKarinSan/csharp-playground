using csharp_playground.utilities.interfaces;

namespace csharp_playground.datastructures.Arrays
{
    class DynamicArrayTest : ITest
    {
        public void RunTest()
        {
            TestAddItem();
            TestGetItem();
            TestRemoveItem();
            TestCurrentArraySize();
            TestTraverseArray();
            Console.WriteLine("All tests completed.");
        }

        private void TestAddItem()
        {
            var dynamicArray = new DynamicArray("int");
            var item1 = new FixedArrayItem(10, "int");
            var item2 = new FixedArrayItem(20, "int");

            dynamicArray.AddItem(item1);
            dynamicArray.AddItem(item2);

            if (dynamicArray.CurrArraySize != 2)
                Console.WriteLine("TestAddItem failed: Expected size 2, got " + dynamicArray.CurrArraySize);
            else
                Console.WriteLine("TestAddItem passed.");
        }

        private void TestGetItem()
        {
            var dynamicArray = new DynamicArray("string");
            var item1 = new FixedArrayItem("Hello", "string");
            var item2 = new FixedArrayItem("World", "string");

            dynamicArray.AddItem(item1);
            dynamicArray.AddItem(item2);

            var result = dynamicArray.GetItem("Hello");
            if (result?.ToString() != "Hello")
                Console.WriteLine("TestGetItem failed: Expected 'Hello', got " + result);
            else
                Console.WriteLine("TestGetItem passed.");
                
            result = dynamicArray.GetItem("World");
            if (result?.ToString() != "World")
                Console.WriteLine("TestGetItem failed: Expected 'World', got " + result);
            else
                Console.WriteLine("TestGetItem passed.");
        }

        private void TestRemoveItem()
        {
            var dynamicArray = new DynamicArray("int");
            var item1 = new FixedArrayItem(10, "int");
            var item2 = new FixedArrayItem(20, "int");

            dynamicArray.AddItem(item1);
            dynamicArray.AddItem(item2);

            bool removed = dynamicArray.RemoveItem(10);
            if (!removed || dynamicArray.CurrArraySize != 1)
                Console.WriteLine("TestRemoveItem failed: Expected size 1 after removal.");
            else
                Console.WriteLine("TestRemoveItem passed.");
        }

        private void TestCurrentArraySize()
        {
            var dynamicArray = new DynamicArray("float");
            var item1 = new FixedArrayItem(10.5f, "float");
            var item2 = new FixedArrayItem(20.5f, "float");

            dynamicArray.AddItem(item1);
            dynamicArray.AddItem(item2);

            if (dynamicArray.CurrArraySize != 2)
                Console.WriteLine("TestCurrentArraySize failed: Expected size 2, got " + dynamicArray.CurrArraySize);
            else
                Console.WriteLine("TestCurrentArraySize passed.");
        }

        private void TestTraverseArray()
        {
            var dynamicArray = new DynamicArray("string");
            var item1 = new FixedArrayItem("Hello", "string");
            var item2 = new FixedArrayItem("World", "string");

            dynamicArray.AddItem(item1);
            dynamicArray.AddItem(item2);

            // Redirecting console output to a string for testing purposes
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                dynamicArray.TraverseArray();
                var result = sw.ToString();

                if (!result.Contains("Start of Dynamic Array") || !result.Contains("End of Dynamic Array"))
                    Console.WriteLine("TestTraverseArray failed: Output format incorrect.");
                else
                    Console.WriteLine("TestTraverseArray passed.");

                // Resetting console output
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
                Console.SetOut(Console.Out);
            }
        }
    }
}
