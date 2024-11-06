namespace source._3200._3254;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-power-of-k-size-subarrays-i">
///         Find the Power of K-Size Subarrays I
///     </a>
/// </summary>
public class Solution
{
    public int[] ResultsArray(int[] nums, int k)
    {
        if (k <= 1) return nums;
        int[] res = new int[nums.Length - k + 1];
        Array.Fill(res, -1);
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count = i == 0 || nums[i] - nums[i - 1] != 1 ? 1 : count + 1;
            if (count >= k)
            {
                res[i - k + 1] = nums[i];
            }
        }

        return res;
    }
}