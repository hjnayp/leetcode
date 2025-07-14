namespace source._2200._2226;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-candies-allocated-to-k-children/">
///         2226. Maximum Candies Allocated to K Children
///     </a>
/// </summary>
public class Solution
{
    public int MaximumCandies(int[] candies, long k)
    {
        long r = candies.Sum((a) => (long)a) / k;
        if (r <= 1)
        {
            return (int)r;
        }

        long l = 1;
        while (l < r)
        {
            long mid = (r + l + 1) / 2;
            long sum = candies.Sum((a) => GetCount(a, mid));

            if (sum >= k)
            {
                l = mid;
            }
            else
            {
                r = mid - 1;
            }
        }

        return (int)l;

        long GetCount(long num, long count)
        {
            return num / count;
        }
    }
}