namespace source._1600._1696;

public class Solution
{
    public int MaxResult(int[] nums, int k)
    {
        int n = nums.Length;
        var dp = new LinkedList<Tuple<int, int>>();
        dp.AddLast(new Tuple<int, int>(nums[0], 0));

        for (var i = 1; i < n; ++i)
        {
            while (dp.Count > 0 && dp.First().Item2 < i - k)
                dp.RemoveFirst();

            int max = nums[i] + (dp.Count > 0 ? dp.First().Item1 : 0);
            var tuple = new Tuple<int, int>(max, i);
            while (dp.Count > 0 && dp.Last().Item1 <= max)
                dp.RemoveLast();

            dp.AddLast(tuple);
        }

        return dp.Last().Item1;
    }
}