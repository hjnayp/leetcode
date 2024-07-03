using JetBrains.Annotations;
using source._1600._1600;

namespace test._1600;

[TestClass]
[TestSubject(typeof(ThroneInheritance))]
public class Test1600
{
    private ThroneInheritance? _throneInheritance;

    [TestMethod]
    public void NormalCase()
    {
        string[]? commands =
        [
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
        ];

        string?[][] parameters =
        [
            ["king"],
            ["king", "andy"],
            ["king", "bob"],
            ["king", "catherine"],
            ["andy", "matthew"],
            ["bob", "alex"],
            ["bob", "asha"],
            [null],
            ["bob"],
            [null]
        ];

        string[]?[] results =
        [
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            ["king", "andy", "matthew", "bob", "alex", "asha", "catherine"],
            null,
            ["king", "andy", "matthew", "alex", "asha", "catherine"]
        ];

        for (int i = 0; i < commands.Length; i++)
        {
            RunCommand(commands[i], parameters[i], results[i]);
        }
    }

    private void RunCommand(string command, string?[] param, string[]? results)
    {
        switch (command)
        {
            case "ThroneInheritance":
                _throneInheritance = new ThroneInheritance(param[0]);
                break;
            case "birth":
                _throneInheritance?.Birth(param[0], param[1]);
                break;
            case "death":
                _throneInheritance?.Death(param[0]);
                break;
            case "getInheritanceOrder":
                string[] result = _throneInheritance?.GetInheritanceOrder()?.ToArray() ?? [];
                CollectionAssert.AreEqual(results, result);
                break;
        }
    }
}