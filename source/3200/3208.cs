namespace source._3200._3208;

/// <summary>
///     <a href="https://leetcode.cn/problems/alternating-groups-ii">
///         Alternating Groups II
///     </a>
/// </summary>
public class Solution
{
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        int count = 1;
        int res = 0;
        int n = colors.Length;
        for (int i = -k + 2; i < n; ++i)
        {
            if (colors[(i + n) % n] != colors[(i - 1 + n) % n])
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count >= k)
            {
                ++res;
            }
        }

        return res;
    }
}