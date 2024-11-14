namespace source._3100._3185;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-pairs-that-form-a-complete-day-ii">
///         Count Pairs That Form a Complete Day II
///     </a>
/// </summary>
public class Solution
{
    public long CountCompleteDayPairs(int[] hours)
    {
        Dictionary<int, int> hourToCount = new();
        for (var i = 0; i < hours.Length; i++)
        {
            hours[i] %= 24;
            hourToCount.TryAdd(hours[i], 0);
            ++hourToCount[hours[i]];
        }

        long pairCount = 0;
        foreach (int hour in hours)
        {
            --hourToCount[hour];
            if (hourToCount.TryGetValue((24 - hour) % 24, out int value))
            {
                pairCount += value;
            }
        }

        return pairCount;
    }
}