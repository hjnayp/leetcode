namespace source._2700._2710;

/// <summary>
///     <a href="https://leetcode.cn/problems/remove-trailing-zeros-from-a-string">
///         Remove Trailing Zeros From s String
///     </a>
/// </summary>
public class Solution
{
    public string RemoveTrailingZeros(string num)
    {
        int idx = num.Length - 1;
        while (idx >= 0 && num[idx] == '0')
        {
            --idx;
        }

        return num[..(idx + 1)];
    }
}