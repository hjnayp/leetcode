namespace source._2900._2917;

public class Solution
{
    public int FindKOr(int[] nums, int k)
    {
        int[] digitCnts = new int[32];
        for (int i = 0; i < 32; ++i)
        {
            foreach (int num in nums)
            {
                if ((num & (1 << i)) > 0)
                {
                    digitCnts[i]++;
                }
            }
        }

        int kOrRes = 0;
        for (int i = 0; i < digitCnts.Length; i++)
        {
            if (digitCnts[i] < k) continue;
            kOrRes |= 1 << i;
        }

        return kOrRes;
    }
}