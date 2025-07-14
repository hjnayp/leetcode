namespace source._3400._3439;

public class Solution
{
    public int MaxFreeTime(int eventTime,
                           int k,
                           int[] startTime,
                           int[] endTime
    )
    {
        int n = startTime.Length;
        int res = 0;
        int sum = 0;
        for (int i = 0; i < n; ++i)
        {
            sum += endTime[i] - startTime[i];
            int left = i < k ? 0 : endTime[i - k];
            int right = i < n - 1 ? startTime[i + 1] : eventTime;

            res = Math.Max(res, right - left - sum);
            if (i >= k - 1)
            {
                sum -= endTime[i - k + 1] - startTime[i - k + 1];
            }
        }

        return res;
    }
}