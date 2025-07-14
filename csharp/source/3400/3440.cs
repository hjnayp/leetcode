namespace source._3400._3440;

public class Solution
{
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        int n = startTime.Length;
        bool[] canMove = new bool[n];

        int t1 = 0;
        int t2 = 0;
        for (int i = 0; i < n; ++i)
        {
            if (endTime[i] - startTime[i] <= t1)
            {
                canMove[i] = true;
            }

            t1 = Math.Max(t1, startTime[i] - (i == 0 ? 0 : endTime[i - 1]));

            if (endTime[^(i + 1)] - startTime[^(i + 1)] <= t2)
            {
                canMove[^(i + 1)] = true;
            }

            t2 = Math.Max(t2, (i == 0 ? eventTime : startTime[^i]) - endTime[^(i + 1)]);
        }

        int res = 0;
        for (int i = 0; i < n; ++i)
        {
            int left = i == 0 ? 0 : endTime[i - 1];
            int right = i == n - 1 ? eventTime : startTime[i + 1];
            var freeTime = right - left;
            if (!canMove[i])
            {
                freeTime -= endTime[i] - startTime[i];
            }

            res = Math.Max(res, freeTime);
        }

        return res;
    }
}