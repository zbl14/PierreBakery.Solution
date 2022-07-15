using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadOrderTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void BreadOrderConstructor_CreatInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(6);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_Int()
    {
      int breadQuantity = 5;
      BreadOrder newBreadOrder = new BreadOrder(5);
      int orderedBreadQuantity = newBreadOrder.BreadQuantity;
      Assert.AreEqual(breadQuantity, orderedBreadQuantity);
    }

    [TestMethod]
    public void BreadOrderCost_ReturnsBreadOrderCost_5()
    {
      int breadQuantity = 1;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity);
      int breadOrderTotal = newBreadOrder.BreadOrderCost();
      Assert.AreEqual(5, breadOrderTotal);
    }
  }
}