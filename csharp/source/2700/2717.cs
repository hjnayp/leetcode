namespace source._2700._2717;

/// <summary>
///     <a href="https://leetcode.cn/problems/semi-ordered-permutation">
///         2717. Semi-Ordered Permutation
///     </a>
/// </summary>
public class Solution
{
    public int SemiOrderedPermutation(int[] nums)
    {
        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];
            if (value >= nums[maxIndex])
            {
                maxIndex = i;
            }

            if (value < nums[minIndex])
            {
                minIndex = i;
            }
        }

        return nums.Length - maxIndex - 1
            + minIndex
            - (maxIndex <= minIndex ? 1 : 0);
    }
}