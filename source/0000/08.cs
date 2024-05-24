namespace source._0000._08;

public class Solution
{
    public int MyAtoi(string s)
    {
        int sign = 1;
        long result = 0;
        bool isStartReading = false;
        foreach (char c in s)
        {
            if (c is ' ')
            {
                if (isStartReading) break;
                continue;
            }

            if (c is '-' or '+')
            {
                if (isStartReading) break;
                sign = c == '-' ? -1 : 1;
                isStartReading = true;
                continue;
            }

            int digit = c - '0';
            if (digit is < 0 or > 9) break;

            result *= 10;
            result += digit;
            if (!isStartReading)
            {
                isStartReading = true;
            }

            if (result > int.MaxValue)
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }
        }

        return (int)result * sign;
    }
}