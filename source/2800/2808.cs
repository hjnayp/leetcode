namespace source._2800._2808;

public class Solution
{
    public int MinimumSeconds(IList<int> nums)
    {
        int n = nums.Count;
        var map = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; ++i)
        {
            map.TryAdd(nums[i], new List<int>());
            map[nums[i]].Add(i);
        }

        int res = n;
        foreach ((_, List<int>? positions) in map)
        {
            int maxDistance = positions[0] + n - positions[^1];
            for (int i = 1; i < positions.Count; ++i)
            {
                maxDistance = Math.Max(maxDistance, positions[i] - positions[i - 1]);
            }

            res = Math.Min(res, maxDistance / 2);
        }

        return res;
    }
}