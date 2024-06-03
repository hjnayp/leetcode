namespace source._1100._1103;

public class Solution
{
    public int[] DistributeCandies(int candies, int peopleNum)
    {
        int p = (int)(Math.Sqrt(2 * candies + 0.25) - 0.5);
        int remaining = (int)(candies - (p + 1) * p * 0.5);
        int rows = p / peopleNum;
        int cols = p % peopleNum;

        int[] distributeCandies = new int[peopleNum];
        for (int i = 0; i < peopleNum; ++i)
        {
            distributeCandies[i] = (i + 1) * rows + (int)(rows * (rows - 1) * 0.5) * peopleNum;
            if (i < cols) distributeCandies[i] += i + 1 + rows * peopleNum;
        }

        distributeCandies[cols] += remaining;
        return distributeCandies;
    }
}