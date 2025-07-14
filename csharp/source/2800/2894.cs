namespace source._2800._2894;

/// <summary>
///     <a href="https://leetcode.cn/problems/divisible-and-non-divisible-sums-difference">
///         2894. Divisible and Non-divisible Sums Difference
///     </a>
/// </summary>
public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int num1 = 0;
        int num2 = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % m is 0)
            {
                num2 += i;
            }
            else
            {
                num1 += i;
            }
        }

        return num1 - num2;
    }
}