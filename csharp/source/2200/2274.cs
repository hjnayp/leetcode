namespace source._2200._2274;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-consecutive-floors-without-special-floors">
///         2274. Maximum Consecutive Floors Without Special Floors
///     </a>
/// </summary>
public class Solution
{
    public int MaxConsecutive(int bottom, int top, int[] special)
    {
        List<int> floors = [bottom - 1];
        floors.AddRange(special);
        floors.Add(top + 1);
        floors.Sort();

        int maxOffset = 0;
        for (int i = 1; i < floors.Count; ++i)
        {
            maxOffset = Math.Max(maxOffset, floors[i] - floors[i - 1] - 1);
        }

        return maxOffset;
    }
}