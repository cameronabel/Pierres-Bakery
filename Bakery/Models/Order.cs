using System.Collections.Generic;
using System;
using System.Linq;

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
    private int ConfirmPrice(Good good)
    {
      int tally = Cart.Select(x => x.Quantity).Sum();
      int mod = tally % (good.BXGO + 1);
      if (mod == good.BXGO)
      {
        return 0;
      }
      else
      {
        return good.Price;
      }


    }
    public void AddGood(dynamic good)
    {
      if (good.Quantity == 1)
      {
        good.Price = ConfirmPrice(good);
        Cart.Add(good);
      }
      else
      {
        int div = good.Quantity / (good.BXGO + 1);
        int mod = good.Quantity % (good.BXGO + 1);
        if (div > 0)
        {
          good.Quantity = div * (good.BXGO + 1);
          good.MultiLabel();
          good.MultiPrice();
          Cart.Add(good);
        }
        Type T = good.GetType();
        for (int i = 0; i < mod; i++)
        {
          Object newGood = Activator.CreateInstance(T);
          AddGood(newGood);
        }
      }
    }
    public string StringReceipt()
    {
      string receipt = "";
      int total = 0;
      foreach (Good good in Cart)
      {
        receipt += $"    {good.Label,32}    {good.Price,4}    \n";
        total += good.Price;
      }
      receipt += $"{total,44}    ";
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