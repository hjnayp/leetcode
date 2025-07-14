using JetBrains.Annotations;
using source.InputParsers;

namespace test.InputParsers;

[TestClass]
[TestSubject(typeof(ArrayParser))]
public class ArrayParserTest
{
    [TestMethod]
    public void one_dimensional()
    {
        string input = "[2,0,0,0,0,0,2]";
        int[] output = new[] { 2, 0, 0, 0, 0, 0, 2 };
        CollectionAssert.AreEqual(output, ArrayParser.ParseOneDimensionalArray<int>(input));

        input = "[1,2,3,4,5,6,7]";
        output = new[] { 1, 2, 3, 4, 5, 6, 7 };
        CollectionAssert.AreEqual(output, ArrayParser.ParseOneDimensionalArray<int>(input));

        input = "[]";
        output = Array.Empty<int>();
        CollectionAssert.AreEqual(output, ArrayParser.ParseOneDimensionalArray<int>(input));
    }

    [TestMethod]
    public void two_dimensional()
    {
        string input = "[[2,0,0,0,0,0,2],[1,2,3,4,5,6,7]]";
        int[][] output = new[]
        {
            new[] { 2, 0, 0, 0, 0, 0, 2 },
            new[] { 1, 2, 3, 4, 5, 6, 7 }
        };
        int[][] result = ArrayParser.ParseTwoDimensionalArray<int>(input);
        for (int i = 0; i < result.Length; i++) CollectionAssert.AreEqual(output[i], result[i]);

        input = "[[]]";
        output = new[] { Array.Empty<int>() };
        result = ArrayParser.ParseTwoDimensionalArray<int>(input);
        for (int i = 0; i < result.Length; i++) CollectionAssert.AreEqual(output[i], result[i]);
    }

    [TestMethod]
    public void char_type()
    {
        char[][] chars = ArrayParser.ParseTwoDimensionalArray<char>(
            "[[X,.,.,X],[.,.,.,X],[.,.,.,X]]");
        char[][] output = new[]
        {
            new[] { 'X', '.', '.', 'X' },
            new[] { '.', '.', '.', 'X' },
            new[] { '.', '.', '.', 'X' }
        };
        for (int i = 0; i < chars.Length; i++) CollectionAssert.AreEqual(output[i], chars[i]);
    }
}