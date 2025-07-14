namespace source._3400._3443;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-manhattan-distance-after-k-changes/description">
///         3443. Maximum Manhattan Distance After K Changes
///     </a>
///     <remarks>
///         问题要求的是全局的最大值而不是最终的最大值，因此需要遍历逐步查询
///     </remarks>
/// </summary>
public class Solution
{
    public int MaxDistance(string s, int k)
    {
        int distance = 0;
        int longitude = 0;
        int latitude = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            switch (ch)
            {
                case 'N':
                    latitude++;
                    break;
                case 'S':
                    latitude--;
                    break;
                case 'E':
                    longitude++;
                    break;
                case 'W':
                    longitude--;
                    break;
            }

            int changeDistance = Math.Abs(longitude) + Math.Abs(latitude) + k * 2;
            changeDistance = Math.Min(changeDistance, i + 1);
            distance = Math.Max(distance, changeDistance);
        }

        return distance;
    }
}