using csharp_playground.utilities.interfaces;
namespace csharp_playground.datastructures.LinkedList;
class SinglyLinkedListTest : ITest
{
    public SinglyLinkedList newSinglyLinkedList;
    public SinglyLinkedList inOrderSinglyLinkedList;

    public SinglyLinkedListTest()
    {
        newSinglyLinkedList = new();
        inOrderSinglyLinkedList = new();
    }
    public void RunTest()
    {
        Console.WriteLine("Normal Singly Linked List");
        newSinglyLinkedList.AddNodeBehind(1);
        newSinglyLinkedList.AddNodeBehind(2);
        newSinglyLinkedList.AddNodeBehind(3);
        newSinglyLinkedList.TraverseSinglyLinkedList();
        Console.WriteLine($"SearchNode 3 (found){newSinglyLinkedList.SearchNode(3)}");
        Console.WriteLine($"SearchNode 5 (not found){newSinglyLinkedList.SearchNode(5)}");
        newSinglyLinkedList.DeleteNode(2);
        newSinglyLinkedList.TraverseSinglyLinkedList();

        Console.WriteLine("\nIn order Singly Linked List");
        inOrderSinglyLinkedList.AddNodeInAscendingOrder(5);
        inOrderSinglyLinkedList.AddNodeInAscendingOrder(7);
        inOrderSinglyLinkedList.AddNodeInAscendingOrder(2);
        inOrderSinglyLinkedList.TraverseSinglyLinkedList();
    }
}
