namespace source._3300._3307;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-k-th-character-in-string-game-ii">
///         3307. Find the K-th Character in String Game II
///     </a>
/// </summary>
public class Solution
{
    public char KthCharacter(long k, int[] operations)
    {
        int distance = 0;
        k--;
        for (int i = (int)Math.Log(k, 2); i >= 0; i--)
        {
            if (((k >> i) & 1) == 1)
            {
                distance += operations[i];
            }
        }

        return (char)('a' + distance % 26);
    }
}