namespace source._0000._27;

/// <summary>
///     <a href="https://leetcode.cn/problems/remove-element">Remove Element</a>
/// </summary>
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int p = nums.Length;
        for (int i = 0; i < p; ++i)
        {
            if (nums[i] != val) continue;
            
            while (p > i && nums[p - 1] == val)
            {
                --p;
            }

            if (p == i) break;
            nums[i] = nums[p-- - 1];
        }

        return p;
    }
}