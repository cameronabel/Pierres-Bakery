
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
      Good testGood = new Good("");
      Assert.AreEqual(typeof(Good), testGood.GetType());
    }
    [TestMethod]
    public void GoodConstructor_AssignsLabelField_String()
    {
      string label = "Test Item";
      Good testGood = new Good(label);
      string result = testGood.Label;
      Assert.AreEqual(label, result);
    }
  }
}