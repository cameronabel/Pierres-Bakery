namespace Bakery.Models
{
  public class Good
  {
    public string Label { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int BXGO { get; set; }
    private void MultiPrice()
    {
      Label = $"{Quantity} x {Label} @ {Price}";
      Price = 0;
    }
    public Good(string label, int basePrice)
    {
      Label = label;
      Price = basePrice;
      Quantity = 1;
    }
  }
}