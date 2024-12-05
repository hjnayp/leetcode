namespace source._3200._3238;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-number-of-winning-players">
///         3238. Find the Number of Winning Players
///     </a>
/// </summary>
public class Solution
{
    private const int BALL_COLOR = 11;

    public int WinningPlayerCount(int n, int[][] pick)
    {
        int[,] playerBallCounts = new int[n, BALL_COLOR];
        foreach (int[] pickInfo in pick)
        {
            int player = pickInfo[0];
            int ball = pickInfo[1];
            playerBallCounts[player, ball]++;
        }

        int count = 0;
        for (int p = 0; p < n; p++)
        for (int c = 0; c < BALL_COLOR; c++)
        {
            if (playerBallCounts[p, c] <= p) continue;
            ++count;
            break;
        }

        return count;
    }
}