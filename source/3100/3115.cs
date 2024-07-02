namespace source._3100._3115;

public class Solution
{
    private static ISet<int> s_primes = new HashSet<int>();
    private static ISet<int> s_notPrimes = new HashSet<int>();

    private static bool IsPrime(int num)
    {
        if (s_primes.Contains(num)) return true;
        if (s_notPrimes.Contains(num)) return false;

        if (num <= 1)
        {
            s_notPrimes.Add(num);
            return false;
        }

        if (num == 2)
        {
            s_primes.Add(num);
            return true;
        }

        int boundary = (int)Math.Floor(Math.Sqrt(num));
        for (int i = 2; i <= boundary; ++i)
        {
            if (num % i != 0) continue;
            s_notPrimes.Add(num);
            return false;
        }

        s_primes.Add(num);
        return true;
    }

    public int MaximumPrimeDifference(int[] nums)
    {
        int i = Array.FindIndex(nums, IsPrime);
        int j = Array.FindLastIndex(nums, IsPrime);

        return j - i;
    }
}