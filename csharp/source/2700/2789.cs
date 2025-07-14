namespace source._2700._2789;

public class Solution
{
    public long MaxArrayValue(int[] nums)
    {
        int n = nums.Length;
        var finals = new List<long>();
        long sum = 0;
        for (int i = n - 1; i >= 0; --i)
        {
            sum += nums[i];
            if (i != 0 && sum >= nums[i - 1]) continue;

            finals.Add(sum);
            sum = 0;
        }

        return finals.Max();
    }
}