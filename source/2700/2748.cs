namespace source._2700._2748;

public class Solution
{
    public int CountBeautifulPairs(int[] nums)
    {
        int pairCnt = 0;
        int[] digitsCnt = new int[10];

        for (int i = 0; i < nums.Length; ++i)
        {
            int lastDigit = LastDigit(nums[i]);
            for (int digit = 0; digit < 10; ++digit)
            {
                if (Gcd(digit, lastDigit) == 1) pairCnt += digitsCnt[digit];
            }

            ++digitsCnt[FirstDigit(nums[i])];
        }

        return pairCnt;

        int FirstDigit(int x)
        {
            while (x >= 10) x /= 10;
            return x;
        }

        int LastDigit(int x)
        {
            return x % 10;
        }

        int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }
    }
}