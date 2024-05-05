namespace source._1600._1652;

public class Solution
{
    public int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        int[] result = new int[n];
        Array.Fill(result, 0);
        if (k == 0) return result;

        int[] prefixSum = new int[n + 1];
        for (int i = 1; i <= n; i++) prefixSum[i] = prefixSum[i - 1] + code[i - 1];
        for (int i = 0; i < code.Length; i++)
        {
            int start = k > 0 ? (i + 1) % n : (i + k + n) % n;
            int end = k > 0 ? (i + k) % n : (i - 1 + n) % n;
            if (start <= end) result[i] = prefixSum[end + 1] - prefixSum[start];
            else result[i] = prefixSum[n] - prefixSum[start] + prefixSum[end + 1];
        }

        return result;
    }
}