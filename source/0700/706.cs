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

    private readonly List<List<KeyValue>?> _data = new(BASE);

    public MyHashMap()
    {
        for (int i = 0; i < BASE; i++)
        {
            _data.Add(new List<KeyValue>());
        }
    }

    public void Put(int key, int value)
    {
        int hashcode = GetHashCode(key);
        if (IsInvalidHashCode(hashcode)) return;

        List<KeyValue>? list = _data[hashcode];
        KeyValue? record = (from item in list
                            where item.Item1 == key
                            select item).FirstOrDefault();

        if (record is null)
        {
            list?.Add(new KeyValue { Item1 = key, Item2 = value });
        }
        else
        {
            record.Item2 = value;
        }
    }

    public int Get(int key)
    {
        int hashcode = GetHashCode(key);
        if (IsInvalidHashCode(hashcode)) return -1;

        List<KeyValue>? list = _data[hashcode];
        KeyValue? record = (from item in list
                            where item.Item1 == key
                            select item).FirstOrDefault();

        return record?.Item2 ?? -1;
    }

    public void Remove(int key)
    {
        int hashcode = GetHashCode(key);
        if (IsInvalidHashCode(hashcode)) return;

        List<KeyValue>? list = _data[hashcode];
        KeyValue? record = (from item in list
                            where item.Item1 == key
                            select item).FirstOrDefault();

        if (record is not null)
        {
            list?.Remove(record);
        }
    }

    private static bool IsInvalidHashCode(int code)
    {
        return code is < 0 or >= BASE;
    }

    private static int GetHashCode(int key)
    {
        return key % BASE;
    }
}