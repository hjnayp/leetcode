namespace source._3200._3248;

/// <summary>
///     <a href="https://leetcode.cn/problems/snake-in-matrix">
///         Snake in Matrix
///     </a>
/// </summary>
public class Solution
{
    public int FinalPositionOfSnake(int n, IList<string> commands)
    {
        return commands.Sum(command => command switch
        {
            "UP" => -n,
            "DOWN" => n,
            "LEFT" => -1,
            "RIGHT" => 1,
            _ => 0,
        });
    }
}