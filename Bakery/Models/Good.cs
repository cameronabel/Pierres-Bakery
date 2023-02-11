namespace Bakery.Models
{
  public class Good
  {
    public string Label { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int BXGO { get; set; }
    public void MultiLabel()
    {
      Label = $"{Quantity,2} x {Label} @ {Price} ea";
      if (BXGO > 0)
      {
        Label += $" B{BXGO}G1 DEAL";
      }
    }
    public void MultiPrice()
    {
      if (BXGO > 0)
      {
        int div = Quantity / (BXGO + 1);
        int mod = Quantity % (BXGO + 1);
        Price = Price * BXGO * div + Price * mod;
      }

    }
    public Good(string label, int basePrice)
    {
      Label = label;
      Price = basePrice;
      Quantity = 1;
    }
  }
}