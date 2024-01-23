namespace source._0600._670;

public class Solution
{
    public int MaximumSwap(int num)
    {
        var digits = num.ToString().ToCharArray();
        var n = digits.Length;
        var maxId = n - 1;
        var id1 = -1;
        var id2 = -1;
        for (var i = n - 1; i >= 0; --i)
        {
            if (digits[i] > digits[maxId])
            {
                maxId = i;
            }
            else if (digits[i] < digits[maxId])
            {
                id1 = i;
                id2 = maxId;
            }
        }

        if (id1 < 0) return num;

        (digits[id1], digits[id2]) = (digits[id2], digits[id1]);
        return int.Parse(new string(digits));
    }
}