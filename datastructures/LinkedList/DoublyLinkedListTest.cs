using csharp_playground.utilities.interfaces;

namespace csharp_playground.datastructures.LinkedList;

class DoublyLinkedListTest : ITest
{
    public DoublyLinkedList fromLeftDoublyLinkedList;
    public DoublyLinkedList fromRightDoublyLinkedList;

    public DoublyLinkedListTest()
    {
        fromLeftDoublyLinkedList = new();
        fromRightDoublyLinkedList = new();
    }
    public void RunTest()
    {
        fromLeftDoublyLinkedList.AddNodeFromLeft(5);
        fromLeftDoublyLinkedList.AddNodeFromLeft(8);
        fromLeftDoublyLinkedList.AddNodeFromRight(11);

        fromLeftDoublyLinkedList.AddNodeFromLeft(1);
        fromLeftDoublyLinkedList.AddNodeFromLeft(1000);
        fromLeftDoublyLinkedList.AddNodeFromLeft(69);

        fromLeftDoublyLinkedList.DeleteNode(8);
        fromLeftDoublyLinkedList.DeleteNode(1);
        fromLeftDoublyLinkedList.DeleteNode(1000);
        fromLeftDoublyLinkedList.DeleteNode(69);

        fromLeftDoublyLinkedList.TraverseFromLeft();
        fromLeftDoublyLinkedList.TraverseFromRight();
    }
}