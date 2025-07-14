namespace source._0000._33;

/// <summary>
///     <a href="https://leetcode.cn/problems/search-in-rotated-sorted-array">
///         Search in Rotated Sorted Array
///     </a>
/// </summary>
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int pivot = 0;
        int n = nums.Length;
        int left = 0;
        int right = n - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[0] > nums[mid])
            {
                pivot = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        left = pivot;
        right = left + n - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int idx = mid % n;

            if (target == nums[idx]) return idx;
            if (nums[idx] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}