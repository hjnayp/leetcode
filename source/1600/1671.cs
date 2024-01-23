namespace source._1600._1671;

public class Solution
{
    public int MinimumMountainRemovals(int[] nums)
    {
        var n = nums.Length;
        var prefix = GetLISArray(nums);
        Array.Reverse(nums);
        var suffix = GetLISArray(nums);
        Array.Reverse(suffix);
        var max = 0;
        for (var i = 0; i < n; ++i)
            if (prefix[i] > 1 && suffix[i] > 1)
                max = Math.Max(max, prefix[i] + suffix[i] - 1);

        return n - max;
    }


    public int[] GetLISArray(IList<int> nums)
    {
        var n = nums.Count;
        var dp = new int[n];
        var seq = new List<int>();
        for (var i = 0; i < n; ++i)
        {
            var index = BinarySearch(seq, nums[i]);
            if (index == seq.Count)
            {
                seq.Add(nums[i]);
                dp[i] = seq.Count;
            }
            else
            {
                seq[index] = nums[i];
                dp[i] = index + 1;
            }
        }

        return dp;
    }

    private int BinarySearch<T>(IList<T> list, T target)
    {
        var low = 0;
        var high = list.Count;
        while (low < high)
        {
            var mid = low + (high - low) / 2;
            if (Comparer<T>.Default.Compare(list[mid], target) < 0)
                low = mid + 1;
            else
                high = mid;
        }

        return low;
    }
}