using JetBrains.Annotations;
using source._0700._721;

namespace test._0700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Teset721
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        IList<IList<string>> accounts =
        [
            ["John", "johnsmith@mail.com", "john_newyork@mail.com"],
            ["John", "johnsmith@mail.com", "john00@mail.com"],
            ["Mary", "mary@mail.com"],
            ["John", "johnnybravo@mail.com"]
        ];

        string[][] expected =
        [
            ["John", "john00@mail.com", "john_newyork@mail.com", "johnsmith@mail.com"],
            ["Mary", "mary@mail.com"],
            ["John", "johnnybravo@mail.com"]
        ];

        CheckResult(expected, solution.AccountsMerge(accounts).Select((a) => a.ToArray()).ToArray());
    }

    [TestMethod]
    public void same_email_in_one_account()
    {
        Solution solution = new();
        IList<IList<string>> accounts =
        [
            ["Alex", "Alex5@m.co", "Alex4@m.co", "Alex0@m.co"], ["Ethan", "Ethan3@m.co", "Ethan3@m.co", "Ethan0@m.co"],
            ["Kevin", "Kevin4@m.co", "Kevin2@m.co", "Kevin2@m.co"], ["Gabe", "Gabe0@m.co", "Gabe3@m.co", "Gabe2@m.co"],
            ["Gabe", "Gabe3@m.co", "Gabe4@m.co", "Gabe2@m.co"]
        ];
        string[][] expected =
        [
            ["Alex", "Alex0@m.co", "Alex4@m.co", "Alex5@m.co"], ["Ethan", "Ethan0@m.co", "Ethan3@m.co"],
            ["Gabe", "Gabe0@m.co", "Gabe2@m.co", "Gabe3@m.co", "Gabe4@m.co"], ["Kevin", "Kevin2@m.co", "Kevin4@m.co"]
        ];

        CheckResult(expected, solution.AccountsMerge(accounts).Select((a) => a.ToArray()).ToArray());
    }

    [TestMethod]
    public void different_account_have_same_name()
    {
        Solution solution = new();
        IList<IList<string>> accounts =
        [
            ["Kevin", "Kevin1@m.co", "Kevin5@m.co", "Kevin2@m.co"], ["Bob", "Bob3@m.co", "Bob1@m.co", "Bob2@m.co"],
            ["Lily", "Lily3@m.co", "Lily2@m.co", "Lily0@m.co"], ["Gabe", "Gabe2@m.co", "Gabe0@m.co", "Gabe2@m.co"],
            ["Kevin", "Kevin4@m.co", "Kevin3@m.co", "Kevin3@m.co"]
        ];
        string[][] expected =
        [
            ["Lily", "Lily0@m.co", "Lily2@m.co", "Lily3@m.co"], ["Gabe", "Gabe0@m.co", "Gabe2@m.co"],
            ["Kevin", "Kevin1@m.co", "Kevin2@m.co", "Kevin5@m.co"], ["Kevin", "Kevin3@m.co", "Kevin4@m.co"],
            ["Bob", "Bob1@m.co", "Bob2@m.co", "Bob3@m.co"]
        ];

        CheckResult(expected, solution.AccountsMerge(accounts).Select((a) => a.ToArray()).ToArray());
    }

    [TestMethod]
    public void different_account_have_same_name2()
    {
        Solution solution = new();
        IList<IList<string>> accounts =
        [
            ["David", "David0@m.co", "David1@m.co"],
            ["David", "David3@m.co", "David4@m.co"],
            ["David", "David4@m.co", "David5@m.co"],
            ["David", "David2@m.co", "David3@m.co"],
            ["David", "David1@m.co", "David2@m.co"]
        ];
        string[][] expected =
        [
            ["David", "David0@m.co", "David1@m.co", "David2@m.co", "David3@m.co", "David4@m.co", "David5@m.co"]
        ];

        CheckResult(expected, solution.AccountsMerge(accounts).Select((a) => a.ToArray()).ToArray());
    }


    private void CheckResult(string[][] expected, string[][] actual)
    {
        Assert.AreEqual(expected.Length, actual.Length);
        Array.Sort(expected, (a, b) =>
        {
            int nameCompare = string.Compare(a[0], b[0], StringComparison.Ordinal);
            return nameCompare != 0 ? nameCompare : a.Length.CompareTo(b.Length);
        });

        Array.Sort(actual, (a, b) =>
        {
            int nameCompare = string.Compare(a[0], b[0], StringComparison.Ordinal);
            return nameCompare != 0 ? nameCompare : a.Length.CompareTo(b.Length);
        });

        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], actual[i]);
        }
    }
}