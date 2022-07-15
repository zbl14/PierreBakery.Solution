using System;

namespace PierreBakery.Models
{
  abstract class Order
  {
    private int _breadPrice = 5;
    private int _pastryPrice = 2;

    public abstract int TotalBreadCost();
    public abstract int TotalPastryCost();

    public abstract int BreadPrice { get; }
    public abstract int PastryPrice { get; }
    
    public int BreadQuantity { get; set; }
    public int PastryQuantity { get; set; }

    // public Order(int breadQuantity, int pastryQuantity)
    // {
    //   _breadPrice = BreadPrice;
    //   _pastryPrice = PastryPrice;
    //   BreadQuantity = breadQuantity;
    //   PastryQuantity = pastryQuantity;
    // }
  }

  public class Bread
  {
    // public BreadOrder (int breadQuantity)
    // {
    //   // _breadPrice = BreadPrice;
    //   // BreadQuantity = breadQuantity;
    // }
  }
}