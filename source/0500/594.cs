namespace source._0500._594;

/// <summary>
///     <a href="https://leetcode.cn/problems/longest-harmonious-subsequence">
///         594. Longest Harmonious Subsequence
///     </a>
/// </summary>
public class Solution
{
    public int FindLHS(int[] nums)
    {
        Dictionary<int, int> numToCount = new();
        foreach (int num in nums)
        {
            numToCount[num] = numToCount.GetValueOrDefault(num, 0) + 1;
        }

        int count = 0;
        foreach (KeyValuePair<int, int> item in numToCount)
        {
            if (numToCount.TryGetValue(item.Key + 1, out int value))
            {
                count = Math.Max(count, item.Value + value);
            }
        }

        return count;
    }
}