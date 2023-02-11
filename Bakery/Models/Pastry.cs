namespace Bakery.Models
{
  public class Pastry : Good
  {
    public Pastry(int quantity)
      : base("Pastry", 2)
    {
      Quantity = quantity;
      BXGO = 3;
      if (Quantity > 1) { MultiLabel(); MultiPrice(); }
    }
  }
}