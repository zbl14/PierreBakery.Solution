using System;
using System.Collections.Generic;
using PierreBakery.Models;

namespace PierreBakery
{
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("=============================\n");
      Console.WriteLine("Would you like some bread or some pastries?\n" + 
        "'B' for Bread, 'P' for pastry, 'Enter' for quit\n");
      Console.WriteLine("Bread: $5 per/loaf, Buy 2 get 1 free\n");
      Console.WriteLine(
        "Pastry:\n" +
        "Buy 1 for $2\n" + 
        "Buy 3 for $5\n" + 
        "Buy 4 for $7\n" + 
        "Buy 5 for $9\n" +
        "Buy half-dozen for $10\n");
      string response = Console.ReadLine();
      if (response.ToUpper() == "B")
      {
        OrderBread();
      }
      else if (response.ToUpper() == "P")
      {
        OrderPastry();
      }
      else
      {
        Quit();
      }
    }

    static void OrderBread()
    {
      Console.WriteLine("How many loaves would you like?");
      int breadQuantity = int.Parse(Console.ReadLine());
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity);
      Console.WriteLine("The total cost of this bread order is $ " + newBreadOrder.BreadOrderCost() + "\n");
      Console.WriteLine("Would you like to check out? 'Y' for yes, 'N' for continue shopping");
      string responseCheckOut = Console.ReadLine();
      if (responseCheckOut.ToUpper() == "Y")
      {
        Checkout();
      }
      Console.WriteLine("Would you like to order some pastries or continue to order bread? 'P' for pastry, 'B' for bread, 'Enter' for quit");
      string response = Console.ReadLine();
      if (response.ToUpper() == "B")
      {
        OrderBread();
      }
      else if (response.ToUpper() == "P")
      {
        OrderPastry();
      }
      else
      {
        Quit();
      }
    }

    static void OrderPastry()
    {
      Console.WriteLine("How many pasties would you like?");
      int pastryQuantity = int.Parse(Console.ReadLine());
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      Console.WriteLine("The total cost of this pastries order is $ " + newPastryOrder.PastryOrderCost() + "\n");
      Console.WriteLine("Would you like to order some bread? 'B' for bread, 'Enter' for quit");
      string response = Console.ReadLine();
      if (response.ToUpper() == "B")
      {
        OrderBread();
      }
      else
      {
        Quit();
      }
    }

    static void Checkout()
    {
      List<BreadOrder> breadCart = BreadOrder.GetAll();
      if (breadCart.Count == 0)
      {
        Console.WriteLine("You don't have any order yet");
        Main();
      }
      else
      {
        int breadTotal = 0;
        foreach (BreadOrder thisOrder in breadCart)
        {
          breadTotal += thisOrder.BreadOrderCost();
        }
        Console.WriteLine("Your total for all bread order is $ " + breadTotal);
      }
    }

    static void Quit()
    {
      Console.WriteLine("====================================");
      Console.WriteLine("Thank you. See you next time. (^‿^)");
    }
  }
}
