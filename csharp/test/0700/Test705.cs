using JetBrains.Annotations;
using source._0700;

namespace test._0700;

[TestClass]
[TestSubject(typeof(MyHashSet))]
public class Test705
{
    [TestMethod]
    public void Normal()
    {
        var myHashSet = new MyHashSet();
        myHashSet.Add(1);
        myHashSet.Add(2);
        Assert.IsTrue(myHashSet.Contains(1));
        Assert.IsFalse(myHashSet.Contains(3));
        myHashSet.Add(2);
        Assert.IsTrue(myHashSet.Contains(2));
        myHashSet.Remove(2);
        Assert.IsFalse(myHashSet.Contains(2));
    }
}