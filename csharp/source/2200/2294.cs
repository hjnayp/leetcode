namespace source._2200._2294;

/// <summary>
///     <a href="https://leetcode.cn/problems/partition-array-such-that-maximum-difference-is-k/">
///         2294. Partition Array Such That Maximum Difference Is K
///     </a>
/// </summary>
public class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        Array.Sort(nums);
        int min = nums[0];
        int max = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Length; ++i)
        {
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
            if (max - min <= k) continue;

            ++count;
            min = nums[i];
            max = nums[i];
        }

        return count;
    }
}