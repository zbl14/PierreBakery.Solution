using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryOrderTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void PastryOrderConstructor_CreatInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(6);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetPastryOrder_ReturnsPastryOrder_Int()
    {
      int pastryQuantity = 5;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int orderedPastryQuantity = newPastryOrder.PastryQuantity;
      Assert.AreEqual(pastryQuantity, orderedPastryQuantity);
    }

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_2()
    {
      int pastryQuantity = 1;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(2, pastryOrderTotal);
    }

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_5()
    {
      int pastryQuantity = 3;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(5, pastryOrderTotal);
    }
  }
}