namespace source._3100._3154;

public class Solution
{
    public int WaysToReachStair(int k)
    {
        int operationCount = 0;
        int jumpUpStep = 1;
        int wayCount = 0;

        while (true)
        {
            int minDownStair = jumpUpStep - operationCount - 1;
            if (minDownStair <= k && k <= jumpUpStep)
            {
                wayCount += Combination(operationCount + 1, jumpUpStep - k);
            }
            else if (minDownStair > k)
            {
                break;
            }

            ++operationCount;
            jumpUpStep *= 2;
        }

        return wayCount;
    }

    int Combination(int n, int k)
    {
        long res = 1;
        for (int i = n; i >= n - k + 1; --i)
        {
            res *= i;
            res /= n - i + 1;
        }

        return (int)res;
    }
}