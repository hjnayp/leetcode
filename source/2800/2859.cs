namespace source._2800._2859;

public class Solution
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        var res = 0;
        var n = nums.Count;
        for (var i = 0; i < n; ++i)
        {
            if (CountSetBits(i) == k)
                res += nums[i];
        }

        return res;
    }

    private int CountSetBits(int x)
    {
        x = (x & 0b0101010101) + ((x & 0b1010101010) >> 1);
        x = ((x & 0b0011001100) >> 2) + (x & 0b1100110011);
        x = (x >> 8) + ((x >> 4) & 0b1111) + (x & 0b1111);
        return x;
    }
}