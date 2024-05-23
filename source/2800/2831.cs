namespace source._2800._2831;

public class Solution
{
    public int LongestEqualSubarray(IList<int> nums, int k)
    {
        var count = new Dictionary<int, int>();
        int max = 0;
        for (int i = 0, j = 0; j < nums.Count; ++j)
        {
            count.TryAdd(nums[j], 0);
            ++count[nums[j]];

            while (j - i + 1 - count[nums[i]] > k)
            {
                --count[nums[i]];
                ++i;
            }

            max = Math.Max(max, count[nums[j]]);
        }

        return max;
    }
}