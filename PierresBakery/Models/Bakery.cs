using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bakery
  {
    public Dictionary<string, int[]> bakeryOrder = new Dictionary<string, int[]>() {};

    public void Order(int breadCount, int pastryCount)
    {
      if (breadCount > 0)
      {
        Bread breadOrder = new Bread(breadCount);
        int breadTotal = breadOrder.CalculateTotal();
        bakeryOrder.Add("bread", new int[]{breadCount, breadTotal});
      } 
      if (pastryCount > 0)
      {
        Pastry pastryOrder = new Pastry(pastryCount);
        int pastryTotal = pastryOrder.CalculateTotal();
        bakeryOrder.Add("pastries", new int[]{pastryCount, pastryTotal});
      }

      // "no order";
    }

    public string PrintOrder()
    {
      bool bread = bakeryOrder.ContainsKey("bread");
      bool pastries = bakeryOrder.ContainsKey("pastries");
      string receipt;
      int orderTotal = 0;

      if(bread && pastries)
      {
        receipt = $"{bakeryOrder["bread"][0]} loaves of bread is ${bakeryOrder["bread"][1]}, and {bakeryOrder["pastries"][0]} pastries is ${bakeryOrder["pastries"][1]}";
        orderTotal = (bakeryOrder["bread"][1]) + (bakeryOrder["pastries"][1]);
      }
      else if(bread)
      {
        receipt = $"{bakeryOrder["bread"][0]} loaves of bread is ${bakeryOrder["bread"][1]}";
        orderTotal = orderTotal + (bakeryOrder["bread"][1]);
      }
      else
      {
        receipt = $"{bakeryOrder["pastries"][0]} pastries is ${bakeryOrder["pastries"][1]}";
        orderTotal = orderTotal + (bakeryOrder["pastries"][1]);
      }
      return $"Your order total for {receipt}. You owe ${orderTotal}.";
    }
  }


  public class Bread
  {
    public int _breadOrder { get; }

    public Bread(int breadOrder)
    {
      _breadOrder = breadOrder;
    }

    public int CalculateTotal()
    {
      int total = 0;

      for (int i=1; i <= _breadOrder; i++)
      {
        if (i%3 != 0)  
        {
          total = total + 5;
        }
      }
      return total;
    }

  }

  public class Pastry
  {
    public int _pastryOrder { get; }

    public Pastry(int pastryOrder)
    {
      _pastryOrder = pastryOrder;
    }

    public int CalculateTotal()
    {
      int total = 0;

      for (int i=1; i <= _pastryOrder; i++)
      {
        if (i%3 != 0)  
        {
          total = total + 2;
        }
        else
        {
          total = total + 1;
        }
      }
      return total;
    }
  }
}


