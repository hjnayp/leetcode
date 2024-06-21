namespace source.Lcp._61;

public class Solution
{
    public int TemperatureTrend(int[] temperatureA, int[] temperatureB)
    {
        int maxSameTemperatureTrendDay = 0;
        int[] temperatureTrendA = InitTemperatureTrend(temperatureA);
        int[] temperatureTrendB = InitTemperatureTrend(temperatureB);
        int days = temperatureTrendA.Length;
        int firstSameTrendDay = -1;
        for (int i = 0; i < days; ++i)
        {
            bool isTrendSame = temperatureTrendA[i] == temperatureTrendB[i];
            if (isTrendSame)
            {
                if (firstSameTrendDay < 0)
                {
                    firstSameTrendDay = i;
                }

                if (i == days - 1)
                {
                    maxSameTemperatureTrendDay = Math.Max(maxSameTemperatureTrendDay, i - firstSameTrendDay + 1);
                    break;
                }

                continue;
            }

            if (firstSameTrendDay < 0) continue;
            maxSameTemperatureTrendDay = Math.Max(maxSameTemperatureTrendDay, i - firstSameTrendDay);
            firstSameTrendDay = -1;
        }

        return maxSameTemperatureTrendDay;

        int[] InitTemperatureTrend(int[] temperatures)
        {
            int[] temperatureTrend = new int[temperatures.Length - 1];
            for (int i = 0; i < temperatures.Length - 1; ++i)
            {
                temperatureTrend[i] = Math.Clamp(temperatures[i + 1] - temperatures[i], -1, 1);
            }

            return temperatureTrend;
        }
    }
}