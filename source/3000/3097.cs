namespace source._3000._3097;

/// <summary>
///     <a href="https://leetcode.cn/problems/shortest-subarray-with-or-at-least-k-ii">
///         3097. Shortest Subarray With OR at Least K II
///     </a>
/// </summary>
public class Solution
{
    private readonly int[] digitOneCounts_ = new int[31];
    private int maxDigitIndex_ = 0;

    public int MinimumSubarrayLength(int[] nums, int k)
    {
        int left = 0;
        int right = 0;
        int subArrayLength = int.MaxValue;
        int n = nums.Length;
        while (right < n)
        {
            CountNumDigitCount(nums[right]);
            while (left <= right && SubArrayOrSum() >= k)
            {
                subArrayLength = Math.Min(subArrayLength, right - left + 1);
                RemoveNumFromDigitCount(nums[left]);
                ++left;
            }

            ++right;
        }

        return subArrayLength == int.MaxValue ? -1 : subArrayLength;
    }

    private int SubArrayOrSum()
    {
        int res = 0;
        for (var i = 0; i < digitOneCounts_.Length; i++)
        {
            if (digitOneCounts_[i] <= 0) continue;

            res |= 1 << i;
        }

        return res;
    }

    private void CountNumDigitCount(int num)
    {
        if (num == 0) return;

        for (int i = 0; i < 31; i++)
        {
            if ((num & (1 << i)) != 0)
            {
                digitOneCounts_[i]++;
            }
        }
    }

    private void RemoveNumFromDigitCount(int num)
    {
        if (num == 0) return;

        for (int i = 0; i < 31; i++)
        {
            if ((num & (1 << i)) != 0)
            {
                digitOneCounts_[i]--;
            }
        }
    }
}