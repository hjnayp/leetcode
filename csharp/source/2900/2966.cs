namespace source._2900._2966;

/// <summary>
///     <a href="https://leetcode.cn/problems/divide-array-into-arrays-with-max-difference">
///         2966. Divide Array Into Arrays With Max Difference
///     </a>
/// </summary>
public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        int n = nums.Length;
        int[][] res = new int[n / 3][];
        Array.Sort(nums);
        for (int i = 0; i < n; i += 3)
        {
            if (nums[i + 2] - nums[i] > k)
            {
                return [];
            }

            res[i / 3] = [nums[i], nums[i + 1], nums[i + 2]];
        }

        return res;
    }
}