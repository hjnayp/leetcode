namespace source.InputHandlers;

public static class InputHandler
{
    /// <summary>
    ///     Convert the input string to an one-dimensional integer array
    /// </summary>
    /// <param name="input">
    ///     The input string that represent an one-dimensional array
    /// </param>
    /// <returns></returns>
    /// <example>
    ///     input = "[2,0,0,0,0,0,2]"
    ///     return = new []{2,0,0,0,0,0,2}
    /// </example>
    public static int[] HandleOneDimensionalArrayInput(string input)
    {
        return input.Trim('[', ']')
            .Split(',')
            .Where((s) => s != "")
            .Select(int.Parse)
            .ToArray();
    }

    /// <summary>
    ///     Convert the input string to a two-dimensional integer array
    /// </summary>
    /// <param name="input">
    ///     The string that represent a two-dimensional array
    /// </param>
    /// <returns></returns>
    /// <example>
    ///     input = "[[2,0,0,0,0,0,2],[1,2,3,4,5,6,7]]"
    ///     input = "[[]]"
    /// </example>
    public static int[][] HandleTwoDimensionalArrayInput(string input)
    {
        return input.Trim('[', ']')
            .Split("],[")
            .Select(HandleOneDimensionalArrayInput)
            .ToArray();
    }
}