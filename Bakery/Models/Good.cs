namespace Bakery.Models
{
  public class Good
  {
    public string Label { get; }
    public int Price { get; }
    public int Quantity { get; }
    public Good(string label, int price)
    {
      Label = label;
      Price = price;
      Quantity = 1;
    }
  }
}