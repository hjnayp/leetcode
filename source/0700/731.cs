namespace source._0700._731;

/// <summary>
///     <a href="https://leetcode.cn/problems/my-calendar-ii">
///         731. My Calendar II
///     </a>
/// </summary>
public class MyCalendarTwo
{
    private readonly SortedDictionary<int, int> posToFrequency_ = new();

    public bool Book(int startTime, int endTime)
    {
        int booked = 0;

        posToFrequency_.TryAdd(startTime, 0);
        posToFrequency_.TryAdd(endTime, 0);

        posToFrequency_[startTime]++;
        posToFrequency_[endTime]--;

        foreach ((_, int frequency) in posToFrequency_)
        {
            booked += frequency;
            if (booked <= 2) continue;

            posToFrequency_[startTime]--;
            posToFrequency_[endTime]++;
            return false;
        }

        return true;
    }
}