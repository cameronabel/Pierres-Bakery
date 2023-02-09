
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class GoodTests
  {
    [TestMethod]
    public void GoodConstructor_CreatesInstanceOfGood_Good()
    {
      Good testGood = new Good("", 1);
      Assert.AreEqual(typeof(Good), testGood.GetType());
    }
    [TestMethod]
    public void GoodConstructor_AssignsLabelField_String()
    {
      string label = "Test Item";
      Good testGood = new Good(label, 1);
      string result = testGood.Label;
      Assert.AreEqual(label, result);
    }
    [TestMethod]
    public void GoodConstructor_AssignsPriceField_Int()
    {
      int price = 2;
      Good testGood = new Good("Test Item", 2);
      int result = testGood.Price;
      Assert.AreEqual(price, result);
    }
  }
}