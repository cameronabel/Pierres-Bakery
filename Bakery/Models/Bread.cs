namespace Bakery.Models
{
  public class Bread : Good
  {
    public Bread(int quantity)
      : base("Bread", 5)
    {
      Quantity = quantity;
      BXGO = 2;
      if (Quantity > 1) { MultiPrice(); }
    }
  }
}