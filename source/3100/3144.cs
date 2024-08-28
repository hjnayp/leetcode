namespace source._3100._3144;

public class Solution
{
    public int MinimumSubstringsInPartition(string s)
    {
        int n = s.Length;
        int[] minPartitionCount = new int[n + 1];
        Array.Fill(minPartitionCount, int.MaxValue);
        minPartitionCount[0] = 0;
        for (int i = 1; i <= n; ++i)
        {
            int maxAppearCount = 0;
            var charToAppearCount = new Dictionary<char, int>();
            for (int j = i; j > 0; --j)
            {
                char ch = s[j - 1];
                charToAppearCount.TryAdd(ch, 0);
                charToAppearCount[ch]++;
                maxAppearCount = Math.Max(maxAppearCount, charToAppearCount[ch]);
                bool isBalanceString = maxAppearCount * charToAppearCount.Count == i - j + 1;
                bool isPreviousStringBalance = minPartitionCount[j - 1] != int.MaxValue;
                if (isPreviousStringBalance &&
                    isBalanceString)
                {
                    minPartitionCount[i] = Math.Min(minPartitionCount[i], minPartitionCount[j - 1] + 1);
                }
            }
        }

        return minPartitionCount[n];
    }
}