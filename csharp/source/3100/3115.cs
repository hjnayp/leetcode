namespace source._3100._3115;

public class Solution
{
    private static readonly ISet<int> Primes = new HashSet<int>();
    private static readonly ISet<int> NotPrimes = new HashSet<int>();

    private static bool IsPrime(int num)
    {
        if (Primes.Contains(num)) return true;
        if (NotPrimes.Contains(num)) return false;

        if (num <= 1)
        {
            NotPrimes.Add(num);
            return false;
        }

        if (num == 2)
        {
            Primes.Add(num);
            return true;
        }

        int boundary = (int)Math.Floor(Math.Sqrt(num));
        for (int i = 2; i <= boundary; ++i)
        {
            if (num % i != 0) continue;
            NotPrimes.Add(num);
            return false;
        }

        Primes.Add(num);
        return true;
    }

    public int MaximumPrimeDifference(int[] nums)
    {
        int i = Array.FindIndex(nums, IsPrime);
        int j = Array.FindLastIndex(nums, IsPrime);

        return j - i;
    }
}