namespace source.InputParsers;

public static class ArrayParser
{
    /// <summary>
    ///     Convert the input string to a one-dimensional array
    /// </summary>
    /// <example>
    ///     input = "[2,0,0,0,0,0,2]"
    ///     return = new []{2,0,0,0,0,0,2}
    /// </example>
    public static T[] ParseOneDimensionalArray<T>(string input)
    {
        return input.Trim('[', ']')
            .Split(',')
            .Where((s) => s != "")
            .Select((value) =>
            {
                value = value.Trim('\'');
                value = value.Trim('"');
                return (T)Convert.ChangeType(value, typeof(T));
            })
            .ToArray();
    }

    /// <summary>
    ///     Convert the input string to a two-dimensional array
    /// </summary>
    /// <example>
    ///     input = "[[2,0,0,0,0,0,2],[1,2,3,4,5,6,7]]"
    ///     input = "[[]]"
    /// </example>
    public static T[][] ParseTwoDimensionalArray<T>(string input)
    {
        return input.Trim('[', ']')
            .Split("],[")
            .Select(ParseOneDimensionalArray<T>)
            .ToArray();
    }
}