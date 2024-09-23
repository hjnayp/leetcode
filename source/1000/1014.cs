namespace source._1000._1014;

/// <summary>
///     <a href="https://leetcode.cn/problems/best-sightseeing-pair">
///         Best Sightseeing Pair
///     </a>
/// </summary>
public class Solution
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        int maxScore = 0;
        int maxScoreSpot = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            int score = values[i] + maxScoreSpot - i;
            maxScore = Math.Max(maxScore, score);
            maxScoreSpot = Math.Max(maxScoreSpot, values[i] + i);
        }

        return maxScore;
    }
}