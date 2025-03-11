namespace source._0700;

public class MyHashSet
{
    private const int BASE = 769;

    private readonly List<List<int>> _data;

    public MyHashSet()
    {
        _data = new List<List<int>>();
        for (int i = 0; i < BASE; ++i)
        {
            _data.Add(new List<int>());
        }
    }

    private static int Hash(int key)
    {
        return key % BASE;
    }

    public void Add(int key)
    {
        int h = Hash(key);
        if (!_data[h].Contains(key))
        {
            _data[h].Add(key);
        }
    }

    public void Remove(int key)
    {
        int h = Hash(key);
        _data[h].Remove(key);
    }

    public bool Contains(int key)
    {
        int h = Hash(key);
        return _data[h].Contains(key);
    }
}