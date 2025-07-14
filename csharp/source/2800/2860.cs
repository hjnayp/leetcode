namespace source._2800._2860;

/// <summary>
///     <a href="https://leetcode.cn/problems/happy-students/description">
///         Happy Students
///     </a>
/// </summary>
public class Solution
{
    public int CountWays(IList<int> nums)
    {
        int n = nums.Count;
        int count = 0;
        ((List<int>)nums).Sort();
        for (int k = 0; k <= n; k++)
        {
            if (k > 0 && nums[k - 1] >= k) continue;
            if (k < n && nums[k] <= k) continue;
            count++;
        }

        return count;
    }
}