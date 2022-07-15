using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class PastryOrder 
  {
    private int _pastryPrice = 2;
    public int PastryPrice;
    public int PastryQuantity { get; set; }
    private static List<PastryOrder> _instances = new List<PastryOrder> {};

    public PastryOrder(int pastryQuantity)
    {
      PastryPrice = _pastryPrice;
      PastryQuantity = pastryQuantity;
      _instances.Add(this);
    }

    public static List<PastryOrder> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int PastryOrderCost()
    {
      int PastryOrderTotal = 0;
      int PastryQuantityModBy6 = PastryQuantity % 6;
      if (PastryQuantityModBy6 == 0)
      {
        PastryOrderTotal = 10 * (PastryQuantity / 6);
      }
      else
      {
        switch(PastryQuantityModBy6)
        {
          case 1:
          case 2:
            PastryOrderTotal = PastryPrice * PastryQuantityModBy6 + 10 * (PastryQuantity / 6);
            break;
          case 3:
          case 4:
          case 5:
            PastryOrderTotal = 5 + 2 * (PastryQuantityModBy6 - 3) + 10 * (PastryQuantity / 6);
            break;
        }
      }
      return PastryOrderTotal;
    }
  }
}