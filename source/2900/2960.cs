namespace source._2900._2960;

public class Solution
{
    public int CountTestedDevices(int[] batteryPercentages)
    {
        int costTime = 0;
        int testedDevicesCnt = 0;
        foreach (int batteryPercentage in batteryPercentages)
        {
            if (batteryPercentage <= costTime) continue;
            ++costTime;
            ++testedDevicesCnt;
        }

        return testedDevicesCnt;
    }
}