namespace source._0000._35;

/// <summary>
///     <a href="https://leetcode.cn/problems/search-insert-position">
///         Search Insert Position
///     </a>
/// </summary>
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (target > nums[^1]) return nums.Length;
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            int mid = (right + left) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return right;
    }
}