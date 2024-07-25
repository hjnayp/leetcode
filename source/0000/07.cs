namespace source._0000._07;

/// <summary>
///     https://leetcode.cn/problems/reverse-integer
/// </summary>
public class Solution
{
    public int Reverse(int x)
    {
        int sign = x > 0 ? 1 : -1;
        long m = Math.Abs((long)x);
        var digits = new List<long>();
        while (m > 0)
        {
            digits.Add(m % 10);
            m /= 10;
        }

        long result = 0;
        for (int i = 0; i < digits.Count; ++i)
        {
            result += digits[^(i + 1)] * (long)Math.Pow(10, i);
            if (result is > int.MaxValue or < int.MinValue)
            {
                return 0;
            }
        }

        return (int)result * sign;
    }
}