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
    public Order()
    {
      _runningCounter++;
      ID = _runningCounter;
    }
  }
}