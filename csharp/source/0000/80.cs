namespace source._0000._80;

/// <summary>
///     <a href="https://leetcode.cn/problems/remove-duplicates-from-sorted-array-ii">
///         80. Remove Duplicates from Sorted Array II
///     </a>
/// </summary>
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        if (n <= 2)
        {
            return n;
        }

        int slow = 2, fast = 2;
        while (fast < n)
        {
            if (nums[slow - 2] != nums[fast])
            {
                nums[slow] = nums[fast];
                slow++;
            }

            fast++;
        }

        return slow;
    }
}