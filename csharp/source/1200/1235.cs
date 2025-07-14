namespace source._1200._1235;

public class Solution
{
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        int n = startTime.Length;
        int[] index = new int [n];
        for (int i = 0; i < index.Length; i++) index[i] = i;
        Array.Sort(index, (a, b) => endTime[a] - endTime[b]);

        int[] dp = new int [n + 1];
        dp[0] = 0;

        for (int i = 1; i < dp.Length; i++)
        {
            int idx = index[i - 1];
            int k = FindK(i - 1, startTime[idx]);
            dp[i] = Math.Max(dp[i - 1], dp[k] + profit[idx]);
        }

        return dp[n];

        int FindK(int right, int target)
        {
            int left = 0;
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (endTime[index[mid]] > target)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}