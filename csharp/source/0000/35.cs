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
        int left = 0;
        int right = nums.Length - 1;
        int index = nums.Length;
        while (left <= right)
        {
            int mid = (right + left) / 2;
            if (nums[mid] >= target)
            {
                right = mid - 1;
                index = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return index;
    }
}