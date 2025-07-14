namespace source._3100._3162;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-number-of-good-pairs-i">
///         Find the Number of Good Pairs I
///     </a>
/// </summary>
public class Solution
{
    public int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        IDictionary<int, int> numToCount = new Dictionary<int, int>();
        IDictionary<int, int> numToCount2 = new Dictionary<int, int>();
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

        int pairCount = 0;

        foreach ((int num, int count) in numToCount2)
        {
            int dividend = num * k;
            for (int val = dividend; val <= maxNum; val += dividend)
            {
                if (numToCount.TryGetValue(val, out int numCount))
                {
                    pairCount += numCount * count;
                }
            }
        }

        return pairCount;
    }
}