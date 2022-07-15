using System;

namespace PierreBakery.Models
{
  public class PastryOrder 
  {
    private int _pastryPrice = 2;
    public int PastryPrice;

    public int PastryQuantity { get; set; }

    public PastryOrder(int pastryQuantity)
    {
      PastryPrice = _pastryPrice;
      PastryQuantity = pastryQuantity;
    }

    public int PastryOrderCost()
    {
      int PastryOrderTotal = 0;
      PastryOrderTotal = PastryPrice * PastryQuantity;
      return PastryOrderTotal;
    }
  }
}