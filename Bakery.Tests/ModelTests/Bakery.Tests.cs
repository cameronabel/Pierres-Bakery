
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

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
  }
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_AssignsLabelField_Bread()
    {
      Bread testBread = new Bread(1);
      string result = testBread.Label;
      Assert.AreEqual("Bread", result);
    }
    [TestMethod]
    public void BreadConstructor_AssignsPriceField_Int()
    {
      Bread testBread = new Bread(1);
      int result = testBread.Price;
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void BreadConstructor_AssignsQuantityField_Int()
    {
      Bread testBreads = new Bread(1);
      int result = testBreads.Quantity;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void BreadConstructor_AssignsMultiPriceField_Int()
    {
      Bread testBreads = new Bread(3);
      int result = testBreads.Price;
      Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void BreadConstructor_AssignsMultiLabelField_String()
    {
      Bread testBreads = new Bread(3);
      string result = testBreads.Label;
      Assert.AreEqual(@" 3 x Bread @ 5 ea B2G1 DEAL", result);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void PastryConstructor_AssignsLabelField_Pastry()
    {
      Pastry testPastry = new Pastry(1);
      string result = testPastry.Label;
      Assert.AreEqual("Pastry", result);
    }
    [TestMethod]
    public void PastryConstructor_AssignsPriceField_Int()
    {
      Pastry testPastry = new Pastry(1);
      int result = testPastry.Price;
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void PastryConstructor_AssignsQuantityField_Int()
    {
      Pastry testPastries = new Pastry(1);
      int result = testPastries.Quantity;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void PastryConstructor_AssignsMultiPriceField_Int()
    {
      Pastry testPastries = new Pastry(4);
      int result = testPastries.Price;
      Assert.AreEqual(6, result);
    }
    [TestMethod]
    public void PastryConstructor_AssignsMultiLabelField_String()
    {
      Pastry testPastries = new Pastry(4);
      string result = testPastries.Label;
      Assert.AreEqual(@" 4 x Pastry @ 2 ea B3G1 DEAL", result);
    }
  }
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order();
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_Assigns_NextOrderNumber_Int()
    {
      Order testOrder = new Order();
      Assert.AreEqual(1, testOrder.ID);
    }
    [TestMethod]
    public void AddGood_AddsGoodToCart_UpdatedCart()
    {
      Order testOrder = new Order();
      Bread testBread = new Bread(1);
      testOrder.AddGood(testBread);
      Assert.AreEqual(1, testOrder.Cart.Count);
    }
    [TestMethod]
    public void StringReceipt_ReturnsStringReceipt_SingleGood()
    {
      Order testOrder = new Order();
      Bread testBread = new Bread(1);
      testOrder.AddGood(testBread);
      string expectedReceipt = $"    {"Bread",32}    {"5",4}    \n";
      Assert.AreEqual(expectedReceipt, testOrder.StringReceipt());
    }
    [TestMethod]
    public void StringReceipt_ReturnsStringReceipt_MultipleGoods()
    {
      Order testOrder = new Order();
      Bread testBread = new Bread(1);
      Pastry testPastries = new Pastry(4);
      testOrder.AddGood(testBread);
      testOrder.AddGood(testPastries);
      string expectedReceipt = $"    {"Bread",32}    {"5",4}    \n    {" 4 x Pastry @ 2 ea B3G1 DEAL",32}    {"6",4}    \n";
      Assert.AreEqual(expectedReceipt, testOrder.StringReceipt());
    }
  }
}