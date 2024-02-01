namespace source._0400._462;

public class Solution
{
    public int MinMoves2(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length;

        // When n is even, median do not need to be the real median
        // it can be any number between the two middle numbers
        int median = nums[n / 2];
        var res = 0;
        for (var i = 0; i < n; ++i)
            res += Math.Abs(nums[i] - median);

        return res;
    }
}