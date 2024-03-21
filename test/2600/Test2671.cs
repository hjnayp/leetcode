using JetBrains.Annotations;
using source._2600._2671;

namespace test._2600;

[TestClass]
[TestSubject(typeof(FrequencyTracker))]
public class Test2671
{
    private static void TestAdd(FrequencyTracker tracker, int number)
    {
        tracker.Add(number);
    }

    private static void TestHasFrequency(FrequencyTracker tracker, int frequency, bool expected)
    {
        Assert.AreEqual(expected, tracker.HasFrequency(frequency));
    }

    [TestMethod]
    public void Case()
    {
        var tracker = new FrequencyTracker();
        TestAdd(tracker, 3);
        TestAdd(tracker, 3);
        TestHasFrequency(tracker,2,true);
    }
}