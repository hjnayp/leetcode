namespace source._0000._31;

/// <summary>
///     <a href="https://leetcode.cn/problems/next-permutation">
///         Next Permutation
///     </a>
/// </summary>
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int less = n - 2;
        while (less >= 0 && nums[less] >= nums[less + 1])
        {
            --less;
        }

        if (less != -1)
        {
            int more = n - 1;
            while (more >= 0 && nums[more] <= nums[less])
            {
                --more;
            }

            (nums[less], nums[more]) = (nums[more], nums[less]);
        }

        Array.Reverse(nums, less + 1, n - less - 1);
    }
}