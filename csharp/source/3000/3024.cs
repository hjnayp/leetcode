namespace source._3000._3024;

/// <summary>
///     <a href="https://leetcode.cn/problems/type-of-triangle/description/?envType=daily-question&envId=2025-06-19">
///         3024. Type of Triangle
///     </a>
/// </summary>
public class Solution
{
    private static readonly Dictionary<int, string> s_dict = new()
    {
        { 0, "none" },
        { 1, "scalene" },
        { 2, "isosceles" },
        { 3, "equilateral" },
    };

    public string TriangleType(int[] nums)
    {
        int type = 0;
        int a = nums[0];
        int b = nums[1];
        int c = nums[2];

        if (!IsValidTrigngle(a, b, c))
        {
            return s_dict[type];
        }

        if (a == b && b == c)
        {
            type = 3;
        }
        else if (a == b || b == c || a == c)
        {
            type = 2;
        }
        else
        {
            type = 1;
        }

        return s_dict[type];
    }

    private bool IsValidTrigngle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}