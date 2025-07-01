namespace source._1400._1498;

public class Solution
{
    private const int MOD = 1_000_000_007;
    private const int MAX_N = 100_005;

    public int NumSubseq(int[] nums, int target)
    {
        var exp2 = new int[MAX_N];
        exp2[0] = 1;
        for (int i = 1; i < MAX_N; ++i)
        {
            exp2[i] = exp2[i - 1] * 2 % MOD;
        }

        Array.Sort(nums);
        int count = 0;
        for (var i = 0; i < nums.Length; ++i)
        {
            if (nums[i] * 2 > target) break;

            int maxValue = target - nums[i];
            int pos = BinarySearch(nums, maxValue) - 1;
            if (pos < i) continue;

            count = (count + exp2[pos - i]) % MOD;
        }

        return count;
    }

    private int BinarySearch(int[] nums, int target)
    {
        int low = 0, high = nums.Length;
        while (low < high)
        {
            int mid = (high - low) / 2 + low;
            if (mid == nums.Length)
            {
                return mid;
            }

            int num = nums[mid];
            if (num <= target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }
}