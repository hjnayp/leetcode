namespace source._2700._2740;

/// <summary>
///     https://leetcode.cn/problems/find-the-value-of-the-partition
/// </summary>
public class Solution
{
    public int FindValueOfPartition(int[] nums)
    {
        Array.Sort(nums);

        int valueOfPartition = int.MaxValue;

        for (int i = 0; i < nums.Length - 1; ++i)
        {
            int partitionValue = nums[i + 1] - nums[i];
            valueOfPartition = Math.Min(valueOfPartition, partitionValue);
        }

        return valueOfPartition;
    }
}