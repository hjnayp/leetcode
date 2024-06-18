using JetBrains.Annotations;
using source._2200._2288;

namespace test._2200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2288
{
    private Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        string sentence = "";
        int discount = 0;


        sentence = "there are $1 $2 and 5$ candies in the shop";
        discount = 50;
        Assert.AreEqual("there are $0.50 $1.00 and 5$ candies in the shop",
            _solution.DiscountPrices(sentence, discount));

        sentence = "1 2 $3 4 $5 $6 7 8$ $9 $10$";
        discount = 100;
        Assert.AreEqual("1 2 $0.00 4 $0.00 $0.00 7 8$ $0.00 $10$", _solution.DiscountPrices(sentence, discount));

        sentence = "706hzu76jjh7yufr5x9ot60v149k5 $7651913186 pw2o $6";
        discount = 28;
        Assert.AreEqual("706hzu76jjh7yufr5x9ot60v149k5 $5509377493.92 pw2o $4.32",
            _solution.DiscountPrices(sentence, discount));
    }
}