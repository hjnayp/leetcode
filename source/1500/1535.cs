namespace source._1500._1535;

public class Solution
{
    public int GetWinner(int[] arr, int k)
    {
        int max = arr[0];
        int consecutiveWins = 0;
        int idx = 1;
        while (consecutiveWins < k && idx < arr.Length)
        {
            int curVal = arr[idx];
            if (curVal > max)
            {
                max = curVal;
                consecutiveWins = 1;
            }
            else
            {
                ++consecutiveWins;
            }

            ++idx;
        }

        return max;
    }
}