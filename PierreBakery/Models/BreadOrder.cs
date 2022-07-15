using System;

namespace PierreBakery.Models
{
  public class BreadOrder 
  {
    private int _breadPrice = 5;
    public int BreadPrice { get; set; }

    public int BreadQuantity { get; set; }

    public BreadOrder(int breadQuantity)
    {
      BreadPrice = _breadPrice;
      BreadQuantity = breadQuantity;
    }

    public int BreadOrderCost()
    {
      int breadOrderTotal = 0;
      breadOrderTotal = BreadPrice * (BreadQuantity - BreadQuantity / 3);
      return breadOrderTotal;
    }
  }
}