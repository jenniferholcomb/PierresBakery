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
          return "pastry";
        } else
        {
          return "no order";
        }

      }
  }

  public class Bread
  {
    public int BreadOrder { get; }

    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
    }
  }

  public class Pastry
  {

  }
}

