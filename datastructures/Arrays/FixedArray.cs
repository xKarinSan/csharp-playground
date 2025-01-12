namespace csharp_playground.datastructures.Arrays;

class FixedArrayItem : IDisposable
{
    public object _value;
    string _dataType;

    public string DataType
    {
        get => _dataType;
        set => _dataType = value;
    }
    public object Value
    {
        get => _value;
        set => _value = value;
    }
    public FixedArrayItem(object value, string dataType)
    {
        Value = value;
        DataType = dataType;
    }

    public void Dispose()
    {
        Value = null;
        DataType = null;
    }

}

class FixedArray
{
    string _dataType;
    int _arrayLength;
    public int ArrayLength
    {
        get => _arrayLength;
        set => _arrayLength = value;
    }
    int _arrayItemCount;

    public int ArrayItemCount
    {
        get => _arrayItemCount;
        set => _arrayItemCount = value;
    }
    FixedArrayItem[] _fixedArray;

    public FixedArrayItem[] GetFixedArray => _fixedArray;
    public FixedArray(int arrayLength, string dataType)
    {
        ArrayLength = arrayLength;
        ArrayItemCount = 0;
        _fixedArray = new FixedArrayItem[ArrayLength];
        _arrayItemCount = 0;
        _dataType = dataType;
    }


    public void AddItem(FixedArrayItem newItem)
    {
        // add at the first empty spot
        if (ArrayItemCount == ArrayLength || newItem.DataType != _dataType) return;
        _fixedArray[ArrayItemCount] = newItem;
        ArrayItemCount++;
    }
    public void RemoveItemAtIndex(int index)
    {
        if (_fixedArray[index] == null)
        {
            Console.WriteLine("Not found!");
        }
        FixedArrayItem targetItem = _fixedArray[index];
        _fixedArray[index] = null;
        ArrayItemCount--;
        targetItem.Dispose();
    }
    
    public FixedArrayItem GetItemByIndex(int index)
    {
        if (index < 0 || index >= ArrayLength) return null;
        return _fixedArray[index];
    }
    public void TraverseArray()
    {
        Console.WriteLine("Start of Fixed Array");
        for (int i = 0; i < _arrayLength; i++)
        {
            var currentArrVal = _fixedArray[i] != null ? _fixedArray[i].Value.ToString() : "null";
            Console.WriteLine($"Index:{i}, Value:{currentArrVal}");
        }
        Console.WriteLine("End of Fixed Array");
    }
}