namespace source._0800._887;

/// <summary>
///     <a href="https://leetcode.cn/problems/super-egg-drop">
///         Super Egg Drop
///     </a>
/// </summary>
public class Solution
{
    private static readonly IDictionary<int, int> HashToMoveCount = new Dictionary<int, int>();

    public int SuperEggDrop(int k, int n)
    {
        int hash = ToHash(k, n);
        if (HashToMoveCount.TryGetValue(hash, out int count)) return count;
        if (k == 1) return HashToMoveCount[hash] = n;
        if (n == 0) return HashToMoveCount[hash] = 0;

        int low = 1;
        int high = n;
        while (low < high - 1)
        {
            int mid = (low + high) / 2;
            int breakCount = SuperEggDrop(k - 1, mid - 1);
            int notBreakCount = SuperEggDrop(k, n - mid);
            if (breakCount < notBreakCount)
            {
                low = mid;
            }
            else if (breakCount > notBreakCount)
            {
                high = mid;
            }
            else
            {
                low = high = mid;
            }
        }

        return HashToMoveCount[hash] = 1 + Math.Min(
            Math.Max(SuperEggDrop(k - 1, low - 1), SuperEggDrop(k, n - low)),
            Math.Max(SuperEggDrop(k - 1, high - 1), SuperEggDrop(k, n - high))
        );
    }

    private int ToHash(int k, int n)
    {
        return n * 1000 + k;
    }
}