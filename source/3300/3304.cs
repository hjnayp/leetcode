using System.Numerics;

namespace source._3300._3304;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-k-th-character-in-string-game-i">
///         3304. Find the K-th Character in String Game I
///     </a>
/// </summary>
public class Solution
{
    public char KthCharacter(int k)
    {
        int count = BitOperations.PopCount((uint)(k - 1)) % 26;
        return (char)('a' + count);
    }
}