namespace source._0500._551;

public class Solution
{
    public bool CheckRecord(string s)
    {
        int absentCount = 0;
        int lateCount = 0;
        foreach (char ch in s)
        {
            if (ch is 'L')
            {
                lateCount++;
                if (lateCount >= 3)
                {
                    return false;
                }
            }
            else
            {
                lateCount = 0;
            }

            if (ch is not 'A') continue;

            absentCount++;
            if (absentCount >= 2)
            {
                return false;
            }
        }

        return true;
    }
}