namespace source._1700._1742;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-number-of-balls-in-a-box">
///         1742. Maximum Number of Balls in a Box
///     </a>
/// </summary>
public class Solution
{
    public int CountBalls(int lowLimit, int highLimit)
    {
        string strHigh = highLimit.ToString();
        string strLow = lowLimit.ToString();
        strLow = strLow.PadLeft(strHigh.Length, '0');

        int len = strHigh.Length;
        int maxSum = len * 9;
        int[,] memo = new int[len, maxSum + 1];

        for (int i = 0; i < len; i++)
        for (int j = 0; j <= maxSum; j++)
        {
            memo[i, j] = -1;
        }

        int res = 0;
        for (int i = 1; i <= maxSum; i++)
        {
            res = Math.Max(res, Dfs(0, i, true, true));
        }

        return res;

        int Dfs(int index, int remainNum, bool isLimitHigh, bool isLimitLow)
        {
            if (index == len) return remainNum == 0 ? 1 : 0;

            if (isLimitHigh == false && isLimitLow == false && memo[index, remainNum] != -1)
            {
                return memo[index, remainNum];
            }

            int low = isLimitLow ? strLow[index] - '0' : 0;
            int high = isLimitHigh ? strHigh[index] - '0' : 9;
            high = Math.Min(high, remainNum);

            int count = 0;
            for (int num = low; num <= high; num++)
            {
                count += Dfs(index + 1, remainNum - num, isLimitHigh && num == high, isLimitLow && num == low);
            }

            if (isLimitLow == false && isLimitHigh == false)
            {
                memo[index, remainNum] = count;
            }

            return count;
        }
    }
}