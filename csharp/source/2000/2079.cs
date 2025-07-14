namespace source._2000._2079;

public class Solution
{
    public int WateringPlants(int[] plants, int capacity)
    {
        int water = capacity;
        int res = 0;
        int n = plants.Length;
        for (int i = 0; i < n; i++)
        {
            ++res;
            int needWater = plants[i];
            if (water >= needWater)
            {
                water -= needWater;
                continue;
            }

            water = capacity - needWater;
            res += 2 * i;
        }

        return res;
    }
}