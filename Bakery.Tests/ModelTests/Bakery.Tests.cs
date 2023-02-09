
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class GoodTests
  {
    [TestMethod]
    public void GoodConstructor_CreatesInstanceOfGood_Good()
    {
      Good testGood = new Good();
      Assert.AreEqual(typeof(Good), testGood.GetType());
    }
  }
}