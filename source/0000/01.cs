namespace source._0000._01;

public class Solution
{
    public int[]? TwoSum(int[] nums, int target)
    {
        var idx = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; ++i)
        {
            int k = target - nums[i];
            if (idx.TryGetValue(k, out int j))
                return new[] { j, i };
            idx[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}