namespace source._0000._26;

/// <summary>
///     <a href="https://leetcode.cn/problems/remove-duplicates-from-sorted-array/">
///         Remove Duplicates from Sorted Array
///     </a>
/// </summary>
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }

        int idx = 0;
        int vIdx = 0;
        int n = nums.Length;
        while (vIdx < n - 1)
        {
            vIdx++;
            if (nums[vIdx] == nums[idx]) continue;
            nums[idx + 1] = nums[vIdx];
            ++idx;
        }

        return idx + 1;
    }
}