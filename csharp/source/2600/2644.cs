namespace source._2600._2644;

public class Solution
{
    public int MaxDivScore(int[] nums, int[] divisors)
    {
        int max = -1;
        int res = -1;
        var count = new Dictionary<int, int>();
        foreach (int divisor in divisors)
        {
            if (!count.TryAdd(divisor, 0)) continue;
            foreach (int num in nums)
            {
                if (num % divisor == 0)
                {
                    ++count[divisor];
                }
            }

            if (count[divisor] > max)
            {
                max = count[divisor];
                res = divisor;
            }
            else if (count[divisor] == max)
            {
                res = Math.Min(res, divisor);
            }
        }

        return res;
    }
}