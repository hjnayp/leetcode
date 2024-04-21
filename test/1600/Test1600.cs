using JetBrains.Annotations;
using source._1600._1600;

namespace test._1600;

[TestClass]
[TestSubject(typeof(ThroneInheritance))]
public class Test1600
{
    private ThroneInheritance _throneInheritance;

    [TestMethod]
    public void NormalCase()
    {
        var commands = new[]
        {
            "ThroneInheritance",
            "birth",
            "birth",
            "birth",
            "birth",
            "birth",
            "birth",
            "getInheritanceOrder",
            "death",
            "getInheritanceOrder"
        };
        string?[][] parameters =
        {
            new[] { "king" },
            new[] { "king", "andy" },
            new[] { "king", "bob" },
            new[] { "king", "catherine" },
            new[] { "andy", "matthew" },
            new[] { "bob", "alex" },
            new[] { "bob", "asha" },
            new string?[] { null },
            new[] { "bob" },
            new string?[] { null }
        };
    }

    private void RunCommand(string command, string[] param)
    {
        switch (command)
        {
            case "ThroneInheritance":
                _throneInheritance = new ThroneInheritance(param[0]);
                break;
            case "birth":
                _throneInheritance.Birth(param[0], param[1]);
                break;
            case "death":
                _throneInheritance.Death(param[0]);
                break;
            case "getInheritanceOrder":
                string[] result = _throneInheritance.GetInheritanceOrder().ToArray();
                CollectionAssert.AreEqual(param, result);
                break;
        }
    }
}