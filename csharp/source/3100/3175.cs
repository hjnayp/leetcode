namespace source._3100._3175;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-first-player-to-win-k-games-in-a-row">
///         Find the First Player to win K Games in a Row
///     </a>
/// </summary>
public class Solution
{
    public int FindWinningPlayer(int[] skills, int k)
    {
        if (k == 1) return skills[0] > skills[1] ? 0 : 1;

        int wins = 0;
        int winner = 0;

        for (int i = 1; i < skills.Length; i++)
        {
            if (skills[i] > skills[winner])
            {
                winner = i;
                wins = 1;
            }
            else
            {
                wins++;
                if (wins >= k) return winner;
            }
        }


        return winner;
    }
}