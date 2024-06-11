namespace source._0800._881;

public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int light = 0;
        int heavy = people.Length - 1;
        int sum = 0;
        while (light <= heavy)
        {
            if (people[light] + people[heavy] <= limit)
            {
                ++light;
                --heavy;
            }
            else
            {
                --heavy;
            }

            ++sum;
        }


        return sum + (light == heavy ? 1 : 0);
    }
}