namespace source._0500._540;

/// <summary>
///     <a href="https://leetcode.cn/problems/single-element-in-a-sorted-array">
///         540. Single Element in a Sorted Array
///     </a>
/// </summary>
public class Solution
{
    public int SingleNonDuplicate(int[] nums)
    {
        int n = nums.Length;

        return Find(0, n - 1);

        int Find(int left, int right)
        {
            while (true)
            {
                if (right == left) return nums[left];

                int mid = (right - left) / 2 + left;
                int newLeft = mid - 1;
                int newRight = mid + 1;

                if (mid + 1 <= right && nums[mid] == nums[mid + 1])
                {
                    newRight = mid + 2;
                }

                if (mid - 1 >= left && nums[mid] == nums[mid - 1])
                {
                    newLeft = mid - 2;
                }

                if (newRight - newLeft is 2) return nums[mid];

                int leftNumCount = newLeft - left + 1;
                if ((leftNumCount & 1) is 1)
                {
                    right = newLeft;
                    continue;
                }

                left = newRight;
            }
        }
    }
}