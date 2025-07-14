namespace source._3200._3274;

/// <summary>
///     <a href="https://leetcode.cn/problems/check-if-two-chessboard-squares-have-the-same-color">
///         3274. Check if Two Chessboard Squares Have the Same Color
///     </a>
/// </summary>
public class Solution
{
    public bool CheckTwoChessboards(string coordinate1, string coordinate2)
    {
        return IsBlack(coordinate1[0], coordinate1[1]) == IsBlack(coordinate2[0], coordinate2[1]);

        bool IsBlack(char x, char y)
        {
            int i = x - 'a' + 1;
            int j = y - '0';

            return (i + j) % 2 == 0;
        }
    }
}