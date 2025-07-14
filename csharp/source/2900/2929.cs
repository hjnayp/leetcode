namespace source._2900._2929;

/// <summary>
///     <a href="https://leetcode.cn/problems/distribute-candies-among-children-ii">
///         2929. Distribute Candies Among Children II
///     </a>
/// </summary>
public class Solution
{
    public long DistributeCandies(int n, int limit)
    {
        if (limit * 3 < n)
        {
            return 0;
        }

        long distributeCount = 0;
        int maxForFirst = Math.Min(n, limit);
        for (long count = 0; count <= maxForFirst; ++count)
        {
            if (limit * 2 < n - count) continue;

            long distribute = Math.Min(limit, n - count) - Math.Max(0, n - count - limit) + 1;
            distributeCount += distribute;
        }

        return distributeCount;
    }
}