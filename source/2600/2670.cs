namespace source._2600._2670;

public class Solution
{
    public int[] DistinctDifferenceArray(int[] nums)
    {
        int n = nums.Length;
        var suffix = new int[n + 1];
        var numsSet = new HashSet<int>();

        for (int i = n - 1; i >= 0; --i)
        {
            numsSet.Add(nums[i]);
            suffix[i] = numsSet.Count;
        }

        numsSet.Clear();
        var res = new int[n];
        for (var i = 0; i < n; ++i)
        {
            numsSet.Add(nums[i]);
            res[i] = numsSet.Count - suffix[i + 1];
        }

        return res;
    }
}