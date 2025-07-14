namespace source._1500._1578;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-time-to-make-rope-colorful/">
///         1578. Minimum Time to Make Rope Colorful
///     </a>
/// </summary>
public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int sum = 0;
        int max = 0;
        int res = 0;
        int preIdx = -1;

        for (var i = 0; i < colors.Length; i++)
        {
            char ch = colors[i];
            if (preIdx is -1
                || ch != colors[preIdx])
            {
                res += sum - max;
                sum = max = neededTime[i];
                preIdx = i;
            }
            else
            {
                sum += neededTime[i];
                max = Math.Max(max, neededTime[i]);
            }
        }

        if (preIdx != colors.Length - 1)
        {
            res += sum - max;
        }

        return res;
    }
}