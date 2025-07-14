using JetBrains.Annotations;
using source._1100._1146;

namespace test._1100;

[TestClass]
[TestSubject(typeof(SnapshotArray))]
public class Test1146
{
    [TestMethod]
    public void NormalCase()
    {
        SnapshotArray snap = CreateSnap(3);
        SetSnap(snap, 0, 5);
        Snap(snap);
        SetSnap(snap, 0, 6);
        GetSnap(snap, 0, 0, 5);
    }

    [TestMethod]
    public void NormalCase2()
    {
        var snap = new SnapshotArray(4);
        Snap(snap);
        Snap(snap);
        GetSnap(snap, 3, 1, 0);
        SetSnap(snap, 2, 4);
        Snap(snap);
        SetSnap(snap, 1, 4);
    }

    [TestMethod]
    public void NormalCase3()
    {
        SnapshotArray snap = CreateSnap(3);
        SetSnap(snap, 1, 6);
        Snap(snap);
        Snap(snap);
        SetSnap(snap, 1, 19);
        SetSnap(snap, 0, 4);
        GetSnap(snap, 2, 1, 0);
        GetSnap(snap, 2, 0, 0);
        GetSnap(snap, 0, 1, 0);
    }

    private SnapshotArray CreateSnap(int length)
    {
        return new SnapshotArray(length);
    }

    private void SetSnap(SnapshotArray snap, int index, int val)
    {
        snap.Set(index, val);
    }

    private void GetSnap(SnapshotArray snap, int index, int snapId, int val)
    {
        Assert.AreEqual(val, snap.Get(index, snapId));
    }

    private void Snap(SnapshotArray snap)
    {
        Assert.AreEqual(snap.SnapId, snap.Snap());
    }
}