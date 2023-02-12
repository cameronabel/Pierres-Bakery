using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public List<Good> Cart { get; set; }
    public int ID { get; }

    private static int _runningCounter = new int();

    public static void ClearAll()
    {
      _runningCounter = 0;
    }
    public void AddGood(Good good)
    {
      Cart.Add(good);
    }
    public string StringReceipt()
    {
      string receipt = "";
      foreach (Good good in Cart)
      {
        receipt += $"    {good.Label,32}            ";
      }
      return receipt;
    }
    public Order()
    {
      _runningCounter++;
      ID = _runningCounter;
      Cart = new List<Good>() { };
    }
  }
}