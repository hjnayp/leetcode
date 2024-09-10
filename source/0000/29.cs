namespace source._0000._29;

/// <summary>
///     <a href="https://leetcode.cn/problems/divide-two-integers/">
///         Divide Two Integers
///     </a>
/// </summary>
public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == 0) return 0;

        if (dividend == int.MinValue)
        {
            if (divisor == 1) return int.MinValue;
            if (divisor == -1) return int.MaxValue;
        }
        
        if (divisor == int.MinValue)
        {
            return dividend == int.MinValue ? 1 : 0;
        }

        bool isReversed = false;
        if (dividend > 0)
        {
            dividend = -dividend;
            isReversed = !isReversed;
        }

        if (divisor > 0)
        {
            divisor = -divisor;
            isReversed = !isReversed;
        }

        int left = 1;
        int right = int.MaxValue;
        int ans = 0;
        while (left <= right)
        {
            int mid = left + ((right - left) >> 1);
            bool isSmaller = IsMultiplyResultSmallerThanTarget(divisor, mid, dividend);
            if (isSmaller)
            {
                ans = mid;
                if (mid == int.MaxValue) break;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return isReversed ? -ans : ans;
    }

    private static bool IsMultiplyResultSmallerThanTarget(int val, int multiply, int target)
    {
        // val and target are negative, multiply is positive
        int result = 0;
        while (multiply != 0)
        {
            if ((multiply & 1) != 0)
            {
                if (result < target - val)
                {
                    return false;
                }

                result += val;
            }

            if (multiply != 1)
            {
                if (val < target - val)
                {
                    return false;
                }

                val += val;
            }

            multiply >>= 1;
        }

        return true;
    }
}