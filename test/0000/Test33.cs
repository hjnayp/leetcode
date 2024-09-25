using source._0000._33;

namespace test._0000;

[TestClass]
public class Test33
{
    private Solution solution;

    [TestInitialize]
    public void Setup()
    {
        solution = new Solution();
    }

    [TestMethod]
    public void Test_Search_In_Empty_Array()
    {
        // setup
        int[] emptyArray = [];
        int target = 5;

        // execute
        int result = solution.Search(emptyArray, target);

        // verify
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void Test_Search_In_Single_Element_Array()
    {
        // setup
        int[] singleElementArray = [3];

        // execute & verify
        Assert.AreEqual(0, solution.Search(singleElementArray, 3));
        Assert.AreEqual(-1, solution.Search(singleElementArray, 5));
        Assert.AreEqual(-1, solution.Search(singleElementArray, 0));
    }

    [TestMethod]
    public void Test_Search_In_Multi_Element_Array()
    {
        // setup
        int[] array = [4, 5, 6, 7, 0, 1, 2];
        int targetPresent = 0;
        int targetAbsent = 3;

        // execute & verify
        Assert.AreEqual(4, solution.Search(array, targetPresent));
        Assert.AreEqual(-1, solution.Search(array, targetAbsent));
    }

    [TestMethod]
    public void Test_Search_In_Multi_Element_Array2()
    {
        // setup
        int[] array = [1, 3];

        // execute & verify
        Assert.AreEqual(1, solution.Search(array, 3));
    }

    [TestMethod]
    public void Test_Search_In_Multi_Element_Array3()
    {
        // setup
        int[] array = [3, 1];

        // execute & verify
        Assert.AreEqual(1, solution.Search(array, 1));
    }

    [TestMethod]
    public void Test_Search_In_Sorted_Array()
    {
        // setup
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        int targetPresent = 5;
        int targetAbsent = 10;

        // execute & verify
        Assert.AreEqual(4, solution.Search(array, targetPresent));
        Assert.AreEqual(-1, solution.Search(array, targetAbsent));
    }
}