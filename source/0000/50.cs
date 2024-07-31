namespace source._0000._50;

/// <summary>
///     https://leetcode.cn/problems/powx-n/description/
/// </summary>
public class Solution
{
    public double MyPow(double x, int n)
    {
        // prevent overflow
        long powIndex = n;
        if (powIndex < 0)
        {
            x = 1 / x;
            powIndex = -powIndex;
        }

        double pow = 1d;
        while (powIndex > 0)
        {
            if ((powIndex & 1) == 1)
            {
                pow *= x;
            }

            x *= x;
            powIndex >>= 1;
        }

        return pow;
    }
}