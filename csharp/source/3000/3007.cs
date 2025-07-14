namespace source._3000._3007;

public class Solution
{
    public long FindMaximumNumber(long k, int x)
    {
        long left = 1;
        long right = (k + 1) << x;
        while (left < right)
        {
            long middle = (left + right + 1) / 2;
            if (AccumulatedPrice(middle, x) > k)
            {
                right = middle - 1;
            }
            else
            {
                left = middle;
            }
        }

        return left;
    }

    private long AccumulatedPrice(long num, int bitPosition)
    {
        long len = 64 - long.LeadingZeroCount(num);
        long res = 0L;

        for (int i = bitPosition; i <= len; i += bitPosition)
        {
            res += AccumulateBitPrice(num, i);
        }

        return res;
    }

    private long AccumulateBitPrice(long num, int bitPosition)
    {
        long period = 1L << bitPosition;
        long res = period / 2 * (num / period);
        if (num % period >= period / 2)
        {
            res += num % period - (period / 2 - 1);
        }

        return res;
    }
}