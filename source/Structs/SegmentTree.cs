namespace source.Structs;

public class SegmentTree
{
    private readonly int[] sums;
    private readonly bool[] hasUpdates;
    private readonly int[] updatedValues;
    private readonly int len;

    public SegmentTree(int[] values)
    {
        len = values.Length;
        int segTreeSize = values.Length * 4;
        sums = new int[segTreeSize];
        hasUpdates = new bool[segTreeSize];
        updatedValues = new int[segTreeSize];

        BuildTree(0, values.Length - 1, 0);
        return;

        void BuildTree(int start, int end, int root)
        {
            if (start == end)
            {
                sums[root] = values[start];
                return;
            }

            int l = Left(root);
            int r = Right(root);
            int mid = Middle(start, end);
            BuildTree(start, mid, l);
            BuildTree(mid + 1, end, r);
            sums[root] = sums[l] + sums[r];
        }
    }

    public SegmentTree(int size) : this(new int[size]) { }

    public int SumRange(int left, int right)
    {
        left = Math.Max(0, left);
        right = Math.Min(len - 1, right);
        return Sum(0, len - 1, 0);

        int Sum(int start, int end, int root)
        {
            if (left <= start && end <= right)
            {
                return sums[root];
            }

            UpdateSegment(start, end, root);

            int mid = Middle(start, end);
            int sum = 0;
            if (left <= mid) sum += Sum(start, mid, Left(root));
            if (mid < right) sum += Sum(mid + 1, end, Right(root));

            return sum;
        }
    }

    public void UpdateRange(int left, int right, int value)
    {
        left = Math.Max(0, left);
        right = Math.Min(len - 1, right);
        DfsUpdate(0, len - 1, 0);
        return;

        void DfsUpdate(int start, int end, int root)
        {
            if (left <= start && end <= right)
            {
                hasUpdates[root] = true;
                updatedValues[root] = value;
                sums[root] = value * (end - start + 1);
                return;
            }

            UpdateSegment(start, end, root);

            int l = Left(root);
            int r = Right(root);
            int mid = Middle(start, end);

            if (left <= mid) DfsUpdate(start, mid, l);
            if (right > mid) DfsUpdate(mid + 1, end, r);

            sums[root] = sums[l] + sums[r];
        }
    }

    private static int Left(int i)
    {
        return i * 2 + 1;
    }

    private static int Right(int i)
    {
        return i * 2 + 2;
    }

    private static int Middle(int l, int r)
    {
        return (r - l) / 2 + l;
    }

    private void UpdateSegment(int start, int end, int root)
    {
        if (!hasUpdates[root]) return;

        int mid = Middle(start, end);
        int l = Left(root);
        int r = Right(root);
        sums[l] = updatedValues[root] * (mid - start + 1);
        sums[r] = updatedValues[root] * (end - mid);
        updatedValues[l] = updatedValues[r] = updatedValues[root];
        hasUpdates[l] = hasUpdates[r] = true;

        hasUpdates[root] = false;
    }
}

