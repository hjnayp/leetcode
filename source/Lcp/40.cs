namespace source.Lcp._40;

/// <summary>
///     https://leetcode.cn/problems/uOAnQW
/// </summary>
public class Solution
{
    public int MaxmiumScore(int[] cards, int cnt)
    {
        Array.Sort(cards, (a, b) => b.CompareTo(a));
        int scoreSum = 0;
        int minEvenIndex = -1;
        int minOddIndex = -1;
        for (int i = 0; i < cnt; ++i)
        {
            int score = cards[i];
            scoreSum += score;

            if ((score & 1) == 0)
            {
                minEvenIndex = i;
            }
            else
            {
                minOddIndex = i;
            }
        }

        if ((scoreSum & 1) == 0)
        {
            return scoreSum;
        }

        int maxScore = 0;
        int[] leftCards = cards.Skip(cnt).ToArray();

        if (~minOddIndex != 0)
        {
            int firstEvenCardIndex = Array.FindIndex(leftCards, a => (a & 1) == 0);
            if (~firstEvenCardIndex != 0)
            {
                maxScore = Math.Max(maxScore, scoreSum - cards[minOddIndex] + leftCards[firstEvenCardIndex]);
            }
        }

        if (~minEvenIndex != 0)
        {
            int firstOddCardIndex = Array.FindIndex(leftCards, a => (a & 1) == 1);
            if (~firstOddCardIndex != 0)
            {
                maxScore = Math.Max(maxScore, scoreSum - cards[minEvenIndex] + leftCards[firstOddCardIndex]);
            }
        }
        
        return maxScore;
    }
}