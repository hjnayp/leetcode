using System.Diagnostics.CodeAnalysis;

namespace source.Structs;

public class SegmentTree2
{
    private readonly int start;
    private readonly int end;
    private readonly SegmentTree2? left;
    private readonly SegmentTree2? right;

    private int value;
    private bool hasUpdate;
    private int updateValue;

    public SegmentTree2(int n) : this(new int[n], 0, n - 1) { }
    public SegmentTree2(int[] values) : this(values, 0, values.Length - 1) { }

    private SegmentTree2(int[] values, int start, int end)
    {
        this.start = start;
        this.end = end;

        if (start == end)
        {
            value = values[start];
            return;
        }

        left = new SegmentTree2(values, start, Mid);
        right = new SegmentTree2(values, Mid + 1, end);
        value = left.value + right.value;
    }

    private int Mid => (end - start) / 2 + start;

    [MemberNotNullWhen(false, nameof(left), nameof(right))]
    private bool IsLeaf => start == end;

    /// <summary>
    ///     Calculates the sum of the values in the specified range [l, r].
    /// </summary>
    /// <param name="l">The left boundary of the range.</param>
    /// <param name="r">The right boundary of the range.</param>
    /// <returns>The sum of the values in the specified range.</returns>
    public int SumRange(int l, int r)
    {
        if (l > r) return 0;
        l = Math.Max(0, l);
        r = Math.Min(end, r);

        if (l <= start && end <= r) return value;
        if (hasUpdate) PropagateUpdate();

        if (IsLeaf) return value;
        int sum = 0;
        if (l <= Mid) sum += left.SumRange(l, r);
        if (Mid < r) sum += right.SumRange(l, r);
        return sum;
    }

    /// <summary>
    ///     Updates the values in the specified range [l, r] to the updatedValue.
    /// </summary>
    /// <param name="l">The left boundary of the range.</param>
    /// <param name="r">The right boundary of the range.</param>
    /// <param name="updatedValue">The value to update the range with.</param>
    public void UpdateRange(int l, int r, int updatedValue)
    {
        if (l > r) return;

        l = Math.Max(0, l);
        r = Math.Min(end, r);

        if (l <= start && end <= r)
        {
            value = updatedValue * (end - start + 1);
            hasUpdate = true;
            updateValue = updatedValue;
            return;
        }

        if (hasUpdate) PropagateUpdate();
        if (IsLeaf) return;

        if (l <= Mid) left.UpdateRange(l, r, updatedValue);
        if (Mid < r) right.UpdateRange(l, r, updatedValue);
        value = left.value + right.value;
    }

    private void PropagateUpdate()
    {
        hasUpdate = false;
        if (left is null || right is null) return;

        left.hasUpdate = right.hasUpdate = true;
        left.updateValue = right.updateValue = updateValue;
        left.value = (left.end - left.start + 1) * updateValue;
        right.value = (right.end - right.start + 1) * updateValue;
    }
}