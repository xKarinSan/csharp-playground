namespace csharp_playground.datastructures.LinkedList;
class DoublyLinkedListNode : IDisposable
{
    int _value;
    DoublyLinkedListNode _leftPointer;
    DoublyLinkedListNode _rightPointer;
    public DoublyLinkedListNode() { }

    public DoublyLinkedListNode(int newValue)
    {
        _value = newValue;
    }
    public int GetValue() => _value;
    public void SetLeftPointer(DoublyLinkedListNode targetNode) => _leftPointer = targetNode;
    public void SetRightPointer(DoublyLinkedListNode targetNode) => _rightPointer = targetNode;

    public DoublyLinkedListNode GetLeftPointer() => _leftPointer;
    public DoublyLinkedListNode GetRightPointer() => _rightPointer;

    public void Dispose()
    {
        _leftPointer = null;
        _rightPointer = null;
    }
}

class DoublyLinkedList
{
    DoublyLinkedListNode _leftHeadNode;
    DoublyLinkedListNode _rightHeadNode;

    public DoublyLinkedList()
    {
        _leftHeadNode = new();
        _rightHeadNode = new();
        _rightHeadNode.SetLeftPointer(_leftHeadNode);
        _leftHeadNode.SetRightPointer(_rightHeadNode);

    }
    public void AddNodeFromLeft(int newValue)
    {
        DoublyLinkedListNode newNode = new(newValue);

        // If the list is empty, initialize it with the new node
        if (_leftHeadNode.GetRightPointer() == null)
        {
            _leftHeadNode.SetRightPointer(newNode);
            newNode.SetLeftPointer(_leftHeadNode);
            newNode.SetRightPointer(_rightHeadNode);
            _rightHeadNode.SetLeftPointer(newNode);
            return;
        }

        // Find the correct position to insert the new node
        DoublyLinkedListNode currentNode = _leftHeadNode.GetRightPointer();

        while (currentNode != _rightHeadNode && currentNode.GetValue() < newValue)
        {
            currentNode = currentNode.GetRightPointer();
        }

        // Insert before currentNode
        DoublyLinkedListNode previousNode = currentNode.GetLeftPointer();

        previousNode.SetRightPointer(newNode);
        newNode.SetLeftPointer(previousNode);
        newNode.SetRightPointer(currentNode);

        if (currentNode != null)
        {
            currentNode.SetLeftPointer(newNode);
        }
    }

    public void AddNodeFromRight(int newValue)
    {
        DoublyLinkedListNode newNode = new(newValue);

        // If the list is empty, initialize it with the new node
        if (_rightHeadNode.GetLeftPointer() == null)
        {
            _rightHeadNode.SetLeftPointer(newNode);
            newNode.SetRightPointer(_rightHeadNode);
            newNode.SetLeftPointer(_leftHeadNode);
            _leftHeadNode.SetRightPointer(newNode);
            return;
        }

        // Find the correct position to insert the new node
        DoublyLinkedListNode currentNode = _rightHeadNode.GetLeftPointer();

        while (currentNode != _leftHeadNode && currentNode.GetValue() > newValue)
        {
            currentNode = currentNode.GetLeftPointer();
        }

        // Insert after current node
        DoublyLinkedListNode nextNode = currentNode.GetRightPointer();

        currentNode.SetRightPointer(newNode);
        newNode.SetLeftPointer(currentNode);

        if (nextNode != null)
        {
            nextNode.SetLeftPointer(newNode);
            newNode.SetRightPointer(nextNode);
        }
    }



    public void TraverseFromLeft()
    {
        DoublyLinkedListNode currentNode = _leftHeadNode;
        Console.WriteLine("Start of Doubly Linked List from the left");
        while (currentNode is not null)
        {
            Console.WriteLine(currentNode.GetValue());
            currentNode = currentNode.GetRightPointer();
        }
        Console.WriteLine("End of Doubly Linked List from the left");
    }

    public void TraverseFromRight()
    {
        DoublyLinkedListNode currentNode = _rightHeadNode;
        Console.WriteLine("Start of Doubly Linked List from the right");
        while (currentNode is not null)
        {
            Console.WriteLine(currentNode.GetValue());
            currentNode = currentNode.GetLeftPointer();
        }
        Console.WriteLine("End of Doubly Linked List from the right");
    }
    public void DeleteNode(int targetNode)
    {
        // start from left node (or right node)
        // cases: 
        // 1) left head is target
        // 2) body is target
        // 3) right head is target
        // 4) cannot find
        if (_leftHeadNode.GetValue() == targetNode)
        {
            DoublyLinkedListNode tempNode = _leftHeadNode.GetRightPointer();
            _leftHeadNode.Dispose();
            tempNode.SetLeftPointer(null);
            _leftHeadNode = tempNode;
            DoublyLinkedListNode nextNode = _leftHeadNode.GetRightPointer();
            nextNode.SetLeftPointer(_leftHeadNode);
            return;
        }
        if (_rightHeadNode.GetValue() == targetNode)
        {
            DoublyLinkedListNode tempNode = _rightHeadNode.GetLeftPointer();
            _rightHeadNode.Dispose();
            tempNode.SetRightPointer(null);
            _rightHeadNode = tempNode;
            DoublyLinkedListNode nextNode = _rightHeadNode.GetLeftPointer();
            nextNode.SetRightPointer(_leftHeadNode);
            return;
        }

        DoublyLinkedListNode previousNode;
        DoublyLinkedListNode currentNode = _leftHeadNode;
        while (currentNode is not null)
        {
            previousNode = currentNode;
            currentNode = currentNode.GetRightPointer();

            if (currentNode.GetValue() == targetNode)
            {
                DoublyLinkedListNode nextNode = currentNode.GetRightPointer();
                previousNode.SetRightPointer(nextNode);
                nextNode.SetLeftPointer(previousNode);
                currentNode.Dispose();
                return;
            }
        }
    }
}

