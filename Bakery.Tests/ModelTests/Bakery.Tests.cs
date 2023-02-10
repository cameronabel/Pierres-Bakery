
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
    [TestMethod]
    public void GoodConstructor_AssignsQuantityField_Int()
    {
      int quantity = 1;
      Good testGood = new Good("Test Item", 2);
      int result = testGood.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]
    public void GoodConstructor_AssignsBXGOField_Int()
    {
      int bxgo = 0;
      Good testGood = new Good("Test Item", 2);
      int result = testGood.BXGO;
      Assert.AreEqual(bxgo, result);
    }
    [TestMethod]
    public void BreadConstructor_AssignsLabelField_Bread()
    {
      Bread testBread = new Bread(2);
      string result = testBread.Label;
      Assert.AreEqual("Bread", result);
    }
    [TestMethod]
    public void BreadConstructor_AssignsPriceField_Int()
    {
      Bread testBread = new Bread(2);
      int result = testBread.Price;
      Assert.AreEqual(5, result);
    }
  }
}