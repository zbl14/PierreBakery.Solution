using System;
using System.Collections.Generic;
using System.Threading;
using PierreBakery.Models;

namespace PierreBakery
{
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine(
        "Welcome to Pierre's Bakery!\n" + 
        "===========================\n");
      Thread.Sleep(1000);
      Console.WriteLine("Would you like some bread or some pastries?\n");
      Console.WriteLine(
        "Bread:\n" + 
        "$5 per/loaf, Buy 2 get 1 free\n");
      Console.WriteLine(
        "Pastry:\n" +
        "Buy 1 for $2\n" + 
        "Buy 3 for $5\n" + 
        "Buy 4 for $7\n" + 
        "Buy 5 for $9\n" +
        "Buy half-dozen for $10\n\n" +
        "'B' for Bread\n" +
        "'P' for Pastry\n" + 
        "'Enter' for Quit\n");
      string response = Console.ReadLine();
      BreadOrPastry(response);
    }

    static void BreadOrPastry(string response)
    {
      if (response.ToUpper() == "B")
      {
        OrderBread();
      }
      else if (response.ToUpper() == "P")
      {
        OrderPastry();
      }
      else if (response.ToUpper() == "C")
      {
        Checkout();
      }
      else
      {
        Quit();
      }
    }

    static void CheckoutOrNot(string responseCheckOut)
    {
      if (responseCheckOut.ToUpper() == "Y")
      {
        Checkout();
      }
      else if (responseCheckOut.ToUpper() == "N")
      {
      Console.WriteLine(
        "Would you like some bread or some pastries?\n\n" + 
        "'B' for Bread\n" +
        "'P' for Pastry\n" + 
        "'C' for Checkout\n" + 
        "'Enter' for Quit");
      string response = Console.ReadLine();
      BreadOrPastry(response);
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
      CheckoutOrNot(responseCheckOut);
    }

    static void OrderPastry()
    {
      Console.WriteLine("How many pasties would you like?");
      int pastryQuantity = int.Parse(Console.ReadLine());
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity);
      Console.WriteLine("The total cost of this pastries order is $ " + newPastryOrder.PastryOrderCost() + "\n");
      Console.WriteLine("Would you like to check out? 'Y' for yes, 'N' for continue shopping");
      string responseCheckOut = Console.ReadLine();
      CheckoutOrNot(responseCheckOut);
    }

    static void Checkout()
    {
      List<BreadOrder> breadCart = BreadOrder.GetAll();
      List<PastryOrder> pastryCart = PastryOrder.GetAll();
      if (breadCart.Count == 0 && pastryCart.Count == 0)
      {
        Console.WriteLine("You don't have any order yet");
        Main();
      }
      else
      {
        int breadTotal = 0, pastryTotal = 0, total = 0;
        foreach (BreadOrder thisOrder in breadCart)
        {
          breadTotal += thisOrder.BreadOrderCost();
        }
        foreach (PastryOrder thisOrder in pastryCart)
        {
          pastryTotal += thisOrder.PastryOrderCost();
        } 
        total = breadTotal + pastryTotal;
        if (breadTotal == 0 || pastryTotal == 0)
        {
          Console.WriteLine("Your total for order(s) is $ " + total + "\n");
          Quit();
        }
        else
        {
          Console.WriteLine(
            "Total for bread is $ " + breadTotal + "\n" +
            "Total for pastries is $ " + pastryTotal + "\n" +
            "Your total is $ " + total + "\n"
          );
          Quit();
        }
      }
    }

    static void Quit()
    {
      Console.WriteLine("====================================");
      Console.WriteLine("Thank you. See you next time. (^???^)");
    }
  }
}
