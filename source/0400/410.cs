namespace source._0400._410;

public class Solution
{
    public int SplitArray(int[] nums, int k)
    {
        long left = nums.Max();
        var right = nums.Sum(a => (long)a);

        while (left < right)
        {
            var mid = (left + right) / 2;
            if (Check(nums, mid, k))
                right = mid;
            else
                left = mid + 1;
        }

        return (int)left;
    }

    private bool Check(int[] nums, long x, int k)
    {
        long sum = 0;
        var cnt = 1;
        foreach (var num in nums)
        {
            if (sum + num > x)
            {
                sum = num;
                ++cnt;
            }
            else
            {
                sum += num;
            }

            if (cnt > k)
                return false;
        }

        return true;
    }
}