using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bakery
  {
  //  Dictionary<string, int[]> bakeryOrder = new Dictionary<string, int[]() {}

    public string Order(int breadCount, int pastryCount)
    {
      if (breadCount > 0)
      {
        Bread breadOrder = new Bread(breadCount);
        int breadTotal = breadOrder.CalculateTotal();
        return "$" + breadTotal.ToString();
      } 
      if (pastryCount > 0)
      {
        Pastry pastryOrder = new Pastry(pastryCount);
        int pastryTotal = pastryOrder.CalculateTotal();
        return "$" + pastryTotal.ToString();
      }

      return "no order";
    }

    public string PrintOrder(int breadTotal, int pastryTotal)
    {
      string receipt;
      if(breadTotal != 0 && pastryTotal != 0)
      {
        receipt = $"loaves of bread is ${breadTotal} and pastries is ${pastryTotal} ";
      }
      else if(breadTotal != 0)
      {
        receipt = $"loaves of bread is ${breadTotal} ";
      }
      else
      {
        receipt = $"pastries is ${pastryTotal} ";
      }
      return $"Your order for {receipt}.";
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


