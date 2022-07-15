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
      switch(PastryQuantity)
      {
        case 1:
        case 2:
          PastryOrderTotal = PastryPrice * PastryQuantity;
          break;
        case 3:
        case 4:
        case 5:
          PastryOrderTotal = 5 + 2 * (PastryQuantity - 3);
          break;
        default:
          PastryOrderTotal = 10 + 1 * (PastryQuantity - 6);
          break;
      }
      return PastryOrderTotal;
    }
  }
}