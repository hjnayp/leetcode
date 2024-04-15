namespace source._0700._706;

/// <summary>
///     https://leetcode.cn/problems/design-hashmap
/// </summary>
public class MyHashMap
{
    private class KeyValue
    {
        public int Item1;
        public int Item2;
    }

    private const int BASE = 769;

    private static int GetHashCode(int key)
    {
        return key % BASE;
    }

    private readonly List<List<KeyValue>?> _data = new(BASE);

    public MyHashMap()
    {
        for (var i = 0; i < BASE; i++)
            _data.Add(new List<KeyValue>());
    }

    public void Put(int key, int value)
    {
        int hashcode = GetHashCode(key);
        List<KeyValue>? list = _data[hashcode];
        if (list is null) return;

        foreach (KeyValue t in from t in list
                               let item = t
                               where item.Item1 == key
                               select t)
        {
            t.Item2 = value;
            return;
        }

        list.Add(new KeyValue { Item1 = key, Item2 = value });
    }

    public int Get(int key)
    {
        int hashcode = GetHashCode(key);
        List<KeyValue>? list = _data[hashcode];
        if (list is null) return -1;

        foreach (KeyValue t in from t in list
                               let item = t
                               where item.Item1 == key
                               select t)
            return t.Item2;

        return -1;
    }

    public void Remove(int key)
    {
        int hashcode = GetHashCode(key);
        List<KeyValue>? list = _data[hashcode];
        if (list is null) return;

        foreach (KeyValue t in from t in list
                               let item = t
                               where item.Item1 == key
                               select t)
        {
            list.Remove(t);
            return;
        }
    }
}