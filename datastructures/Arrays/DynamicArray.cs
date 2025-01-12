namespace csharp_playground.datastructures.Arrays;

class DynamicArray
{
    string _dataType;
    List<FixedArray> _array = new();
    public int CurrArraySize
    {
        get
        {
            var count = 0;
            foreach (var subArr in _array)
            {
                foreach (var item in subArr.GetFixedArray)
                {
                    count += item != null ? 1 : 0;
                }
            }
            return count;
        }
    }
    public DynamicArray(string dataType)
    {
        _dataType = dataType;
        _array.Add(new(4, _dataType));
    }

    public void AddItem(FixedArrayItem newItem)
    {
        if (newItem.DataType != _dataType) return;

        // inside array item
        for (int i = 0; i < _array.Count; i++)
        {
            for (int j = 0; j < _array[i].GetFixedArray.Length; j++)
            {
                if (_array[i].GetFixedArray[j] == null)
                {
                    _array[i].GetFixedArray[j] = newItem;
                    return;
                }
            }
        }
        _array.Add(new(4, _dataType));
        _array[_array.Count - 1].GetFixedArray[0] = newItem;
    }

    public object GetItem(object targetValue)
    {
        for (int i = 0; i < _array.Count; i++)
        {
            for (int j = 0; j < _array[i].GetFixedArray.Length; j++)
            {
                if (_array[i].GetFixedArray[j].Value.Equals(targetValue))
                {
                    return _array[i].GetFixedArray[j].Value;
                }
            }
        }
        return null;
    }

    public bool RemoveItem(object targetValue)
    {
        for (int i = 0; i < _array.Count; i++)
        {
            for (int j = 0; j < _array[i].GetFixedArray.Length; j++)
            {
                var item = _array[i].GetFixedArray[j];
                if (item != null && item.Value.Equals(targetValue)) // Check if item is not null
                {
                    item.Dispose(); // Dispose the item
                    _array[i].GetFixedArray[j] = null; // Set the reference to null
                    return true;
                }
            }
        }
        return false;
    }

    public void TraverseArray()
    {
        Console.WriteLine("Start of Dynamic Array");
        // inside array item
        for (int i = 0; i < _array.Count; i++)
        {
            for (int j = 0; j < _array[i].GetFixedArray.Length; j++)
            {
                var currentArrVal = _array[i].GetFixedArray[j] != null ? _array[i].GetFixedArray[j].Value.ToString() : "null";
                Console.WriteLine($"Index:{i}, Value:{currentArrVal}");
            }
        }
        Console.WriteLine("End of Dynamic Array");
    }
}