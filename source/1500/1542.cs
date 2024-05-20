namespace source._1500._1542;

public class Solution
{
    public int LongestAwesome(string s)
    {
        var prefix = new Dictionary<int, int>
        {
            [0] = -1
        };

        int res = 0;
        int sequence = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int digit = s[i] - '0';
            sequence ^= 1 << digit;
            if (!prefix.TryAdd(sequence, i))
            {
                res = Math.Max(res, i - prefix[sequence]);
            }

            for (int j = 0; j < 10; j++)
            {
                int newSequence = sequence ^ (1 << j);
                if (prefix.TryGetValue(newSequence, out int value))
                {
                    res = Math.Max(res, i - value);
                }
            }
        }

        return res;
    }
}