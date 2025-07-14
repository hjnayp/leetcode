namespace test.AssertHelpers;

public class TwoDimensionalArrayAssert
{
    public static bool AreEquivalent<T>(IList<IList<T>> array1, IList<IList<T>> array2)
    {
        if (array1.Count != array2.Count) return false;

        var sortedArray1 = array1.Select(subArray => subArray.OrderBy(x => x).ToArray())
            .OrderBy(subArray => string.Join(",", subArray)).ToList();
        var sortedArray2 = array2.Select(subArray => subArray.OrderBy(x => x).ToArray())
            .OrderBy(subArray => string.Join(",", subArray)).ToList();

        return !sortedArray1.Where((t, i) => !t.SequenceEqual(sortedArray2[i])).Any();
    }
}