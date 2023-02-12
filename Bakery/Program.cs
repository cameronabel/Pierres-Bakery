using Bakery.Models;
using System;

namespace Bakery
{
  public class Program
  {
    private static void Checkout(Order order)
    {
      Console.WriteLine($"Your total due is ${order.GetTotalPrice()}.");
      Console.WriteLine("Press Return for your receipt.");
      Console.ReadLine();
      Console.WriteLine(order.StringReceipt());
    }
    private static void ParseUserInput(string userInput, Order order)
    {
      if (userInput.Length == 1)
      {
        switch (userInput)
        {
          case "1":
            order.AddGood(new Bread());
            break;
          case "2":
            order.AddGood(new Pastry());
            break;
          default:
            Console.WriteLine("I didn't get that. Try again.");
            break;
        }
      }
      else if (userInput.Contains(" "))
      {
        string[] selections = userInput.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
        if (selections.Length == 1)
        {
          ParseUserInput(selections[0], order);
        }
        else if (selections.Length > 2)
        {
          Console.WriteLine("I didn't get that. Try again.");
        }
        else
        {
          try
          {
            int qty = Int32.Parse(selections[1]);
            if (qty > 0)
            {
              switch (selections[0])
              {
                case "1":
                  order.AddGood(new Bread(qty));
                  break;
                case "2":
                  order.AddGood(new Pastry(qty));
                  break;
                default:
                  Console.WriteLine("I didn't get that. Try again.");
                  break;
              }
            }
            else
            {
              Console.WriteLine("Quantities should be positive! Try again.");
            }
          }
          catch (FormatException ex)
          {
            Console.WriteLine(ex);
            Console.WriteLine("I didn't get that. Try again.");
          }

        }
      }

    }
    public static void Main()
    {
      string greeting = @"
            Bienvenue à la Boulangerie de Pierre!

        Welcome in! Please make a selection from the menu.
                                    ┌─────────────┐
                  Specials          │   le Menu   │
            ─────────────────────   │ 1.Bread  $5 │
               Bread: Buy 2 Get 1   │ 2.Pastry $2 │
            Pastries: Buy 3 Get 1   │ 3.Checkout  │
                                    └─────────────┘
Select an item from the menu. To order multiple items, enter
the item number, followed by a space, followed by the quantity.
";
      Console.WriteLine(greeting);
      Order order = new Order();
      string userInput = "";
      while (userInput != "3")
      {
        Console.Write(">>> ");
        userInput = Console.ReadLine();
        if (userInput.ToLower() == "help")
        {
          Console.WriteLine(greeting);
        }
        else if (userInput.ToLower() == "quit" || userInput.ToLower() == "exit")
        {
          System.Environment.Exit(1);
        }
        else if (userInput == "3")
        {
          Checkout(order);
        }
        else
        {
          ParseUserInput(userInput, order);
        }
      }
    }
  }
}