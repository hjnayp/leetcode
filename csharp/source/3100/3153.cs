namespace source._3100._3153;

/// <summary>
///     <a href="https://leetcode.cn/problems/sum-of-digit-differences-of-all-pairs">Link</a>
/// </summary>
public class Solution
{
    public long SumDigitDifferences(int[] nums)
    {
        long differenceSum = 0;
        int n = nums.Length;
        while (nums[0] > 0)
        {
            int[] digitCounts = new int[10];
            for (int i = 0; i < n; i++)
            {
                digitCounts[nums[i] % 10]++;
                nums[i] /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                differenceSum += (long)(n - digitCounts[i]) * digitCounts[i];
            }
        }

        return differenceSum / 2;
    }
}