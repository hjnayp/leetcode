namespace source._0000._81;

/// <summary>
///     <a href="https://leetcode.cn/problems/search-in-rotated-sorted-array-ii">
///         81. Search in Rotated Sorted Array II
///     </a>
/// </summary>
public class Solution
{
    public bool Search(int[] nums, int target)
    {
        if (nums.Length == 0) return false;

        if (nums.Length == 1) return target == nums[0];

        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int searchNum = nums[mid];
            if (target == searchNum) return true;

            if (nums[left] == searchNum && searchNum == nums[right])
            {
                ++left;
                --right;
            }
            else if (searchNum <= nums[right])
            {
                if (target > searchNum && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            else
            {
                if (target >= nums[left] && target < searchNum)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }

        return false;
    }
}