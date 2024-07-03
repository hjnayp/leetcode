namespace source._3000._3099;

public class Solution
{
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        int digitSum = 0;
        int num = x;
        while (num > 0)
        {
            digitSum += num % 10;
            num /= 10;
        }

        return x % digitSum == 0 ? digitSum : -1;
    }
}