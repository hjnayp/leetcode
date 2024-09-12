namespace source._2500._2576;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-maximum-number-of-marked-indices">
///         Find the Maximum Number of Marked Indices
///     </a>
/// </summary>
public class Solution
{
    public int MaxNumOfMarkedIndices(int[] nums)
    {
        Array.Sort(nums, (a, b) => a.CompareTo(b));
        int n = nums.Length;
        int left = 0;
        int right = n / 2;
        int indexCount = 0;

        while (right < n && left < n / 2)
        {
            while (right < n && 2 * nums[left] > nums[right])
            {
                ++right;
            }

            if (right < n)
            {
                indexCount += 2;
                ++right;
            }

            ++left;
        }

        return indexCount;
    }
}