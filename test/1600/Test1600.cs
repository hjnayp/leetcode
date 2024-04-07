using JetBrains.Annotations;
using source._1600._1600;

namespace test._1600;

[TestClass]
[TestSubject(typeof(ThroneInheritance))]
public class Test1600
{
    [TestMethod]
    public void NormalCase()
    {
        var throneInheritance = new ThroneInheritance("king");
        throneInheritance.Birth("king", "andy");
        throneInheritance.Birth("king", "bob");
        throneInheritance.Birth("king", "catherine");
        throneInheritance.Birth("andy", "matthew");
        throneInheritance.Birth("bob", "alex");
        throneInheritance.Birth("bob", "asha");
        CollectionAssert.AreEqual(new[] { "king", "andy", "matthew", "bob", "alex", "asha", "catherine" },
                                  throneInheritance.GetInheritanceOrder().ToArray());
        throneInheritance.Death("bob");
        CollectionAssert.AreEqual(new[] { "king", "andy", "matthew", "alex", "asha", "catherine" },
                                  throneInheritance.GetInheritanceOrder().ToArray());
    }
}