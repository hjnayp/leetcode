namespace source._0000._34;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-first-and-last-position-of-element-in-sorted-array">
///         Find First and Last Position of Element in Sorted Array
///     </a>
/// </summary>
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        return [FindFirst(nums, target), FindLast(nums, target)];
    }

    private static int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] >= target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        if (left < 0 || left >= nums.Length) return -1;
        return nums[left] == target ? left : -1;
    }

    private static int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] <= target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (right < 0 || right >= nums.Length) return -1;
        return nums[right] == target ? right : -1;
    }
}