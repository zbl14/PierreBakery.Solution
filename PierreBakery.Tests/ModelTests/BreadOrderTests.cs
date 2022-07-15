using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadOrderTests : IDisposable
  {
    public void Dispose()
    {
      BreadOrder.ClearAll();
    }

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
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity);
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

    [TestMethod]
    public void BreadOrderCost_ReturnsBreadOrderCost_10()
    {
      int breadQuantity = 3;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity);
      int breadOrderTotal = newBreadOrder.BreadOrderCost();
      Assert.AreEqual(10, breadOrderTotal);
    }

    [TestMethod]
    public void BreadOrderCost_ReturnsBreadOrderCost_15()
    {
      int breadQuantity = 4;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity);
      int breadOrderTotal = newBreadOrder.BreadOrderCost();
      Assert.AreEqual(15, breadOrderTotal);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyBreadOrderCostList_CostList()
    {
      List<BreadOrder> newList = new List<BreadOrder> { };
      List<BreadOrder> result = BreadOrder.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrderCost_CostList()
    {
      int breadQuantity1 = 1;
      int breadQuantity2 = 2;
      BreadOrder newBreadOrder1 = new BreadOrder(breadQuantity1);
      BreadOrder newBreadOrder2 = new BreadOrder(breadQuantity2);
      List<BreadOrder> newList = new List<BreadOrder> { newBreadOrder1, newBreadOrder2};
      List<BreadOrder> result = BreadOrder.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }


    // [TestMethod]
    // public void TotalOrderCost_ReturnsTotalOrderCost_7()
    // {
    //   int breadQuantity = 1;
    //   int pastryQuantity = 1;
    //   BreadOrder newBreadOrder = new BreadOrder(breadQuantity);
    //   PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
    //   int orderTotal = newBreadOrder.BreadOrderCost() + newPastryOrder.PastryOrderCost();
    //   Assert.AreEqual(7, orderTotal);
    // }
  }
}