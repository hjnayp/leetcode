namespace source._2200._2276;

public class CountIntervals
{
    private int _count;
    private SortedDictionary<int, int> _intervals = new();
    private List<int> _keys = new();

    public void Add(int left, int right)
    {
        var interval = FloorEntry(right);
        while (interval != null && interval.Value.Value >= left)
        {
            var l = interval.Value.Key;
            var r = interval.Value.Value;
            left = Math.Min(left, l);
            right = Math.Max(right, r);
            _count -= r - l + 1;
            _intervals.Remove(interval.Value.Key);
            _keys.Remove(interval.Value.Key);
            interval = FloorEntry(right);
        }

        _intervals[left] = right;
        _keys.Add(left);
        _keys.Sort();
        _count += right - left + 1;
    }

    public int Count()
    {
        return _count;
    }

    private KeyValuePair<int, int>? FloorEntry(int key)
    {
        var index = _keys.BinarySearch(key);
        _keys = _intervals.Keys.ToList();
        if (index >= 0)
            return new KeyValuePair<int, int>(_keys[index], _intervals[_keys[index]]);

        index = ~index;
        if (index == 0)
            return null;

        return new KeyValuePair<int, int>(_keys[index - 1], _intervals[_keys[index - 1]]);
    }
}