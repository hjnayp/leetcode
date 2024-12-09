namespace source._1800._1812;

/// <summary>
///     <a href="https://leetcode.cn/problems/determine-color-of-a-chessboard-square">
///         1812. Determine Color of a Chessboard Square
///     </a>
/// </summary>
public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        int x = coordinates[0] - 'a';
        int y = coordinates[1] - '1';
        return (x + y) % 2 == 1;
    }
}