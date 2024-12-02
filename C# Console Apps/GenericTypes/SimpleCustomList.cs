public class SimpleCustomList<T>
{
    private T[] _items = new T[4];
    private int _size = 0;

    public void Add(T item)
    {
        if(_size >= _items.Length)
        {
            var newItems = new T[_items.Length * 2];
            for(int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }

            _items = newItems;
        }

        _items[_size] = item;
        ++_size;
    }
}
