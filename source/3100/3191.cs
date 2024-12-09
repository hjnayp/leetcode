namespace source._3100._3191;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-operations-to-make-binary-array-elements-equal-to-one-i">
///         Minimum Operations to Make Binary Array Elements Equal to One I
///     </a>
/// </summary>
public class Solution
{
    public int MinOperations(int[] nums)
    {
        int operationCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0) continue;
            if (i > nums.Length - 3) return -1;

            operationCount++;
            nums[i] ^= 1;
            nums[i + 1] ^= 1;
            nums[i + 2] ^= 1;
        }

        return operationCount;
    }
}