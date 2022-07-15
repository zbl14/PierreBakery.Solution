using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class BreadOrder 
  {
    private int _breadPrice = 5;
    public int BreadPrice { get; set; }
    public int BreadQuantity { get; set; }
    private static List<BreadOrder> _instances = new List<BreadOrder> {};

    public BreadOrder(int breadQuantity)
    {
      BreadPrice = _breadPrice;
      BreadQuantity = breadQuantity;
      _instances.Add(this);
    }

    public static List<BreadOrder> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int BreadOrderCost()
    {
      int breadOrderTotal;
      breadOrderTotal = BreadPrice * (BreadQuantity - BreadQuantity / 3);
      return breadOrderTotal;
    }

    // public int TotalOrderCost()
    // {
    //   int orderTotal = 0;
    //   orderTotal = orderTotal + BreadOrderCost() + PastryOrder.PastryOrderCost();
    //   return orderTotal;
    // }
  }
}