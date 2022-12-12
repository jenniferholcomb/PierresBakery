using System;
using PierresBakery.Models;

namespace PierresBakery 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello, welcome to Pierres Bakery!");
      Console.WriteLine("Today we have bread and pastries.");
      Console.WriteLine("Bread is $5/loaf, but if you buy 2, your third loaf is free!");
      Console.WriteLine("Our pastries special for today is 3 pastries for $5. Regular price for pastries is $2/pastry.");
      Console.WriteLine("How many loaves of bread would you like?");
      int breadInput = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like today?");
      int pastryInput = int.Parse(Console.ReadLine());

      if (breadInput > 0 || pastryInput > 0)
      {
        Bakery inputBakery = new Bakery();
        inputBakery.Order(breadInput, pastryInput);
        string receipt = inputBakery.PrintOrder();
        Console.WriteLine(receipt);
      }
      else
      {
        Main();
      }
    }
  }
}