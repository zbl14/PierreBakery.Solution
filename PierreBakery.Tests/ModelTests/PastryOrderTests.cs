using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryOrderTests : IDisposable
  {
    public void Dispose()
    {
      PastryOrder.ClearAll();
    }

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

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_4()
    {
      int pastryQuantity = 2;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(4, pastryOrderTotal);
    }

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_7()
    {
      int pastryQuantity = 4;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(7, pastryOrderTotal);
    }

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_9()
    {
      int pastryQuantity = 5;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(9, pastryOrderTotal);
    }

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_10()
    {
      int pastryQuantity = 6;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(10, pastryOrderTotal);
    }

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_12()
    {
      int pastryQuantity = 7;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(12, pastryOrderTotal);
    }

    [TestMethod]
    public void PastryOrderCost_ReturnsPastryOrderCost_20()
    {
      int pastryQuantity = 12;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      int pastryOrderTotal = newPastryOrder.PastryOrderCost();
      Assert.AreEqual(20, pastryOrderTotal);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyPastryOrderCostList_CostList()
    {
      List<PastryOrder> newList = new List<PastryOrder> { };
      List<PastryOrder> result = PastryOrder.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrderCost_CostList()
    {
      int pastryQuantity1 = 1;
      int pastryQuantity2 = 2;
      PastryOrder newPastryOrder1 = new PastryOrder(pastryQuantity1);
      PastryOrder newPastryOrder2 = new PastryOrder(pastryQuantity2);
      List<PastryOrder> newList = new List<PastryOrder> { newPastryOrder1, newPastryOrder2};
      List<PastryOrder> result = PastryOrder.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}