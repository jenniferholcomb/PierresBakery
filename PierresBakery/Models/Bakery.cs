//using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bakery
  {
      public string Order(int breadCount, int pastryCount)
      {
        if (breadCount > 0 && pastryCount > 0)
        {
          return "both";
        }
        else if (breadCount > 0 && pastryCount == 0)
        {
          Bread breadOrder = new Bread(breadCount);
          return "$10";
        }
        else if (pastryCount > 0 && breadCount == 0)
        {
          Pastry pastryOrder = new Pastry(pastryCount);
          return "$2";
        } else
        {
          return "no order";
        }

      }
  }

  public class Bread
  {
    private int _breadOrder { get; }

    public Bread(int breadOrder)
    {
      _breadOrder = breadOrder;
    }

    public int CalculateTotal()
    {
      int total = 0;

      for (int i=1; i <= _breadOrder; i++)
      {
        if (i%3 != 0)   //(i==1 || i==2 || (i%3 != 0))
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

  public class Pastry
  {
    private int PastryOrder { get; }

    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
  }
}

