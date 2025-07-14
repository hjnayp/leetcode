namespace source._2300._2369;

public class Solution
{
    public bool ValidPartition(int[] nums)
    {
        int n = nums.Length;
        var dp = new bool[n + 1];
        dp[0] = true;

        for (var i = 1; i <= n; ++i)
        {
            if (i >= 2)
                dp[i] = dp[i] || (dp[i - 2] && IsValid2(nums[i - 2], nums[i - 1]));
            if (i >= 3)
                dp[i] = dp[i] || (dp[i - 3] && IsValid3(nums[i - 3], nums[i - 2], nums[i - 1]));
        }

        return dp[n];

        bool IsValid2(int a, int b)
        {
            return a == b;
        }

        bool IsValid3(int a, int b, int c)
        {
            return (a == b && b == c) || (a + 1 == b && b + 1 == c);
        }
    }
}