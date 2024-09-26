namespace source._2500._2535;

/// <summary>
///     <a href="https://leetcode.cn/problems/difference-between-element-sum-and-digit-sum-of-an-array">
///         Difference Between
///     </a>
/// </summary>
public class Solution
{
    public int DifferenceOfSum(int[] nums)
    {
        int eleSum = nums.Sum();
        int digitSum = nums.Sum(DigitSum);
        return eleSum - digitSum;
    }

    private static int DigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;
            sum += digit;
        }

        return sum;
    }
}