namespace source._2600._2614;

/// <summary>
///     <a href="https://leetcode.cn/problems/prime-in-diagonal">
///         2614. Prime In Diagonal
///     </a>
/// </summary>
public class Solution
{
    public int DiagonalPrime(int[][] nums)
    {
        int n = nums.Length;
        int max = 0;

        for (int i = 0; i < nums.Length; i++)
        for (int j = 0; j < nums[0].Length; j++)
        {
            if (isDiagonal(i, j) is false) continue;

            int val = nums[i][j];
            if (IsPrime(val))
            {
                max = Math.Max(max, val);
            }
        }

        return max;

        bool isDiagonal(int i, int j)
        {
            return i == j || i + j == n - 1;
        }
    }

    private bool IsPrime(int num)
    {
        if (num == 1)
        {
            return false;
        }

        int factor = 2;
        while (factor * factor <= num)
        {
            if (num % factor == 0)
            {
                return false;
            }

            factor++;
        }

        return true;
    }
}