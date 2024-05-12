namespace source._2100._2105;

public class Solution
{
    public int MinimumRefill(int[] plants, int capacityA, int capacityB)
    {
        int n = plants.Length;
        int waterA = capacityA;
        int waterB = capacityB;
        int refill = 0;

        int posA = 0;
        int posB = n - 1;

        while (posA < posB)
        {
            waterA -= plants[posA];
            waterB -= plants[posB];


            if (waterA < 0)
            {
                ++refill;
                waterA = capacityA - plants[posA];
            }

            if (waterB < 0)
            {
                ++refill;
                waterB = capacityB - plants[posB];
            }

            ++posA;
            --posB;
        }

        if (posA != posB) return refill;
        if (Math.Max(waterA, waterB) < plants[posA]) ++refill;
        return refill;
    }
}