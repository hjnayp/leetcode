namespace source._3100._3164;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-number-of-good-pairs-ii">
///         Find the Number of Good Pairs II
///     </a>
/// </summary>
public class Solution
{
    public long NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        IDictionary<long, long> numToCount = new Dictionary<long, long>();
        IDictionary<long, long> numToCount2 = new Dictionary<long, long>();
        int maxNum = 0;
        foreach (int i in nums1)
        {
            maxNum = Math.Max(maxNum, i);
            numToCount.TryAdd(i, 0);
            numToCount[i]++;
        }

        foreach (int i in nums2)
        {
            numToCount2.TryAdd(i, 0);
            numToCount2[i]++;
        }

        long pairCount = 0;

        foreach ((long num, long count) in numToCount2)
        {
            long dividend = num * k;
            for (long val = dividend; val <= maxNum; val += dividend)
            {
                if (numToCount.TryGetValue(val, out long numCount))
                {
                    pairCount += numCount * count;
                }
            }
        }

        return pairCount;
    }
}