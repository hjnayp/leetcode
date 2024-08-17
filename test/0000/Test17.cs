using JetBrains.Annotations;
using source._0000._17;

namespace test._0000;

[TestClass, TestSubject(typeof(Solution))]
public class Test17
{

    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        string[] expected = ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"];
        CollectionAssert.AreEqual(expected, solution.LetterCombinations("23").ToArray());

        expected = [];
        CollectionAssert.AreEqual(expected, solution.LetterCombinations("").ToArray());
        
        expected = ["a", "b", "c"];
        CollectionAssert.AreEqual(expected, solution.LetterCombinations("2").ToArray());
    }
}