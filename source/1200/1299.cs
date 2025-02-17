namespace source._1200._1299;

/// <summary>
///     <a href="https://leetcode.cn/problems/replace-elements-with-greatest-element-on-right-side">
///         1299. Replace Elements with Greatest Element on Right Side
///     </a>
/// </summary>
public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int maxValue = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int num = arr[i];
            arr[i] = maxValue;
            maxValue = Math.Max(maxValue, num);
        }

        return arr;
    }
}