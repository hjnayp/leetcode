namespace source._3100._3133;

public class Solution
{
    public long MinEnd(int n, int x)
    {
        int filledIndex = 0;
        long len = 64 - int.LeadingZeroCount(x) - int.LeadingZeroCount(n - 1);
        long res = x;
        for (int i = 0; i < len; ++i)
        {
            if (IsBitOne(res, i)) continue;

            if (IsBitOne(n - 1, filledIndex))
            {
                res |= 1L << i;
            }

            ++filledIndex;
        }

        return res;
    }

    private bool IsBitOne(long number, int bitIndex)
    {
        return (number & (1L << bitIndex)) is not 0;
    }
}