namespace source._1100._1146;

public class SnapshotArray
{
    private readonly List<List<Tuple<int, int>>> _vals = new();

    public SnapshotArray(int length)
    {
        for (int i = 0; i < length; i++)
        {
            var arr = new List<Tuple<int, int>> { new(SnapId, 0) };
            _vals.Add(arr);
        }
    }

    public int SnapId { get; private set; }

    public void Set(int index, int val)
    {
        List<Tuple<int, int>> arr = _vals[index];
        if (arr[^1].Item1 == SnapId)
            arr[^1] = new Tuple<int, int>(SnapId, val);
        else
            arr.Add(new Tuple<int, int>(SnapId, val));
    }

    public int Snap()
    {
        return SnapId++;
    }

    public int Get(int index, int snapId)
    {
        int x = BinarySearch(index, snapId);
        return _vals[index][x].Item2;
    }

    private int BinarySearch(int index, int snapId)
    {
        List<Tuple<int, int>> vals = _vals[index];

        int latestSnapId = vals[^1].Item1;
        if (latestSnapId <= snapId) return vals.Count - 1;

        int low = 0;
        int high = vals.Count;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            Tuple<int, int> pair = _vals[index][mid];
            if (pair.Item1 == snapId) return mid;

            if (pair.Item1 > snapId || (pair.Item1 == snapId && pair.Item2 > 0))
                high = mid;
            else
                low = mid + 1;
        }

        while (vals[low].Item1 > snapId) return low - 1;
        return low;
    }
}