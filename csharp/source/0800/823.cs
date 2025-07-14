namespace source._0800._823;

public class Solution
{
    private const int kMod = (int)1e9 + 7;

    public int NumFactoredBinaryTrees(int[] arr)
    {
        int n = arr.Length;
        int[] dp = new int[n];
        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            dp[i] = 1;
            for (int left = 0; left < i; ++left)
            {
                int right = i - 1;
                while (right >= left && (long)arr[left] * arr[right] > arr[i]) --right;
                if (right < left || (long)arr[left] * arr[right] != arr[i]) continue;
                dp[i] = (int)((dp[i] + (long)dp[left] * dp[right] * (arr[left] == arr[right] ? 1 : 2)) % kMod);
            }
        }

        return dp.Aggregate((accumulate, value) => (int)((long)accumulate + value) % kMod);
    }
}