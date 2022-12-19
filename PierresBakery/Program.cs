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
        Console.WriteLine("Would you like to order any more bread or pastries?");
        Console.WriteLine("type y for yes, or n for no");
        string userResponse = Console.ReadLine();

        do
        {
          Console.WriteLine("How many more loaves of bread would you like?");
          int moreBread = int.Parse(Console.ReadLine());
          Console.WriteLine("How many more pastries would you like?");
          int morePastries = int.Parse(Console.ReadLine());
          inputBakery.Order(breadInput, pastryInput);
          Console.WriteLine("Would you like to order any more bread or pastries?");
          Console.WriteLine("type y for yes, or n for no");
          userResponse = Console.ReadLine();
        }
        while (userResponse == "y");

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