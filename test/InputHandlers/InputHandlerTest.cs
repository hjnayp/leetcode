using JetBrains.Annotations;
using source.InputHandlers;

namespace test.InputHandlers;

[TestClass]
[TestSubject(typeof(InputHandler))]
public class InputHandlerTest
{
    [TestMethod]
    public void one_dimensional()
    {
        string input = "[2,0,0,0,0,0,2]";
        int[] output = new[] { 2, 0, 0, 0, 0, 0, 2 };
        CollectionAssert.AreEqual(output, InputHandler.HandleOneDimensionalArrayInput(input));

        input = "[1,2,3,4,5,6,7]";
        output = new[] { 1, 2, 3, 4, 5, 6, 7 };
        CollectionAssert.AreEqual(output, InputHandler.HandleOneDimensionalArrayInput(input));

        input = "[]";
        output = Array.Empty<int>();
        CollectionAssert.AreEqual(output, InputHandler.HandleOneDimensionalArrayInput(input));
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
        int[][] result = InputHandler.HandleTwoDimensionalArrayInput(input);
        for (int i = 0; i < result.Length; i++)
        {
            CollectionAssert.AreEqual(output[i], result[i]);
        }

        input = "[[]]";
        output = new[] { Array.Empty<int>() };
        result = InputHandler.HandleTwoDimensionalArrayInput(input);
        for (int i = 0; i < result.Length; i++)
        {
            CollectionAssert.AreEqual(output[i], result[i]);
        }
    }
}