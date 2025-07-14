namespace source._0000._01;

/// <summary>
///     <a href="https://leetcode.cn/problems/two-sum">Tow Sum</a>
/// </summary>
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var idx = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            int k = target - nums[i];
            if (idx.TryGetValue(k, out int j))
            {
                return [j, i];
            }

            idx[nums[i]] = i;
        }

        return [];
    }
}