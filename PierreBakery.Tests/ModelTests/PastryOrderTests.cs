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
      PastryOrder newPastryOrder = new PastryOrder(5);
      int orderedPastryQuantity = newPastryOrder.PastryQuantity;
      Assert.AreEqual(pastryQuantity, orderedPastryQuantity);
    }
  }
}