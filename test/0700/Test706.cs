using JetBrains.Annotations;
using source._0700._706;

namespace test._0700;

[TestClass]
[TestSubject(typeof(MyHashMap))]
public class Test706
{
    [TestMethod]
    public void normal_case()
    {
        MyHashMap? hashMap = new();
        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        Assert.AreEqual(1, hashMap.Get(1));
        Assert.AreEqual(-1, hashMap.Get(3));
        hashMap.Put(2, 1);
        Assert.AreEqual(1, hashMap.Get(2));
        hashMap.Remove(2);
        Assert.AreEqual(-1, hashMap.Get(2));
    }

    [TestMethod]
    public void unexpected_action()
    {
        MyHashMap? hashMap = new();
        hashMap.Put(-1, 1);
        Assert.AreEqual(-1, hashMap.Get(-1));
        hashMap.Remove(-1);
    }
}