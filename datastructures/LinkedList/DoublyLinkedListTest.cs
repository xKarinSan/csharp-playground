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
        fromLeftDoublyLinkedList.TraverseFromLeft();
        fromLeftDoublyLinkedList.TraverseFromRight();


        fromLeftDoublyLinkedList.AddNodeFromLeft(8);
        fromLeftDoublyLinkedList.TraverseFromLeft();
        fromLeftDoublyLinkedList.TraverseFromRight();
        
        fromLeftDoublyLinkedList.AddNodeFromRight(11);
        fromLeftDoublyLinkedList.TraverseFromLeft();
        fromLeftDoublyLinkedList.TraverseFromRight();

        fromLeftDoublyLinkedList.AddNodeFromLeft(1);
        fromLeftDoublyLinkedList.TraverseFromLeft();
        fromLeftDoublyLinkedList.TraverseFromRight();

        // fromLeftDoublyLinkedList.TraverseFromLeft();
        // fromLeftDoublyLinkedList.TraverseFromRight();
    }
}