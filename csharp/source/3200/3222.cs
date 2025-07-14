namespace source._3200._3222;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-winning-player-in-coin-game">
///         Find the Winning Player in Coin Game
///     </a>
/// </summary>
public class Solution
{
    public string LosingPlayer(int x, int y)
    {
        int z = Math.Min(x, y / 4);
        return z % 2 == 0 ? "Bob" : "Alice";
    }
}