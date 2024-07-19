namespace source._3000._3096;

public class Solution
{
    public int MinimumLevels(int[] possible)
    {
        int scoreSum = possible.Sum((i) =>
        {
            if (i is 1) return 1;
            return -1;
        });

        int currentScore = 0;
        for (int i = 0; i < possible.Length-1; ++i)
        {
            currentScore += possible[i] == 1 ? 1 : -1;
            if (currentScore * 2 > scoreSum)
            {
                return i + 1;
            }
        }

        return -1;
    }
}