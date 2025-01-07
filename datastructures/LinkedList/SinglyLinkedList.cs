namespace csharp_playground.datastructures.SinglyLinkedList;
class SinglyLinkedListNode : IDisposable
{
    public SinglyLinkedListNode? nextNodePointer;
    int _value;

    public SinglyLinkedListNode(int newValue)
    {
        _value = newValue;
    }

    public SinglyLinkedListNode() { }
    public void SetNextPointer(SinglyLinkedListNode newNodePointer) => nextNodePointer = newNodePointer;
    public int GetValue() => _value;
    public SinglyLinkedListNode GetNextPointer() => nextNodePointer is not null ? nextNodePointer : null;
    public void Dispose() { }
}

class SinglyLinkedList
{
    SinglyLinkedListNode _head;
    public SinglyLinkedList()
    {
        _head = new();
    }
    public SinglyLinkedList(int newValue)
    {
        _head = new(newValue);
    }

    public void AddNodeInAscendingOrder(int newValue)
    {
        // SinglyLinkedListNode currentNode = _head;
        // while (currentNode.GetNextPointer() is not null && currentNode.GetValue() < newValue)
        // {
        //     currentNode = currentNode.GetNextPointer();
        // }
        // SinglyLinkedListNode newNode = new(newValue);
        // currentNode.SetNextPointer(newNode);
        SinglyLinkedListNode newNode = new(newValue);
        if (_head == null || _head.GetValue() > newValue)
        {
            newNode.SetNextPointer(_head); // Point to current head
            _head = newNode; // Update head to new node
            return;
        }
        SinglyLinkedListNode previousNode = null;
        SinglyLinkedListNode currentNode = _head;

        while (currentNode is not null && currentNode.GetValue() < newValue)
        {
            previousNode = currentNode;
            currentNode = currentNode.GetNextPointer();
        }
        previousNode.SetNextPointer(newNode);
        newNode.SetNextPointer(currentNode);
    }

    public void AddNodeBehind(int newValue)
    {
        SinglyLinkedListNode nextNode = _head;
        while (nextNode.GetNextPointer() is not null)
        {
            nextNode = nextNode.GetNextPointer();
        }
        SinglyLinkedListNode newNode = new(newValue);
        nextNode.SetNextPointer(newNode);
    }

    public void TraverseSinglyLinkedList()
    {
        SinglyLinkedListNode currentNode = _head;
        Console.WriteLine("Start of Linked List");
        while (currentNode is not null)
        {
            Console.WriteLine(currentNode.GetValue());
            currentNode = currentNode.GetNextPointer();
        }
        Console.WriteLine("End of Linked List");
    }

    public SinglyLinkedListNode SearchNode(int nodeValue)
    {
        SinglyLinkedListNode currentNode = _head;
        while (currentNode is not null && currentNode.GetValue() != nodeValue)
        {
            currentNode = currentNode.GetNextPointer();
        }
        return currentNode;
    }

    public void DeleteNode(int nodeValue)
    {
        if (_head == null) return;
        SinglyLinkedListNode previousNode = _head;
        SinglyLinkedListNode currentNode = _head;

        while (currentNode is not null && currentNode.GetValue() != nodeValue)
        {
            previousNode = currentNode;
            currentNode = currentNode.GetNextPointer();
        }
        if (currentNode == null) return;
        previousNode.SetNextPointer(currentNode.GetNextPointer());
        currentNode.Dispose();
    }
}
