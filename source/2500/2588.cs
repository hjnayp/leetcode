namespace source._2500._2588;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-the-number-of-beautiful-subarrays">
///         2588. Count the Number of Beautiful Subarrays
///     </a>
/// </summary>
public class Solution
{
    public long BeautifulSubarrays(int[] nums)
    {
        var maskToCount = new Dictionary<int, int>();

        int mask = 0;
        long count = 0;
        maskToCount[0] = 1;

        foreach (int num in nums)
        {
            mask ^= num;
            if (maskToCount.TryGetValue(mask, out int maskCount))
            {
                count += maskCount;
                maskToCount[mask] += 1;
            }
            else
            {
                maskToCount[mask] = 1;
            }
        }

        return count;
    }
}