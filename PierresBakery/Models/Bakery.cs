//using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bakery
  {
      public string OrderFilter(int breadCount, int pastryCount)
      {
        if (breadCount > 0 && pastryCount > 0)
        {
          return "both";
        }
        else if (breadCount > 0 && pastryCount == 0)
        {
          return "bread";
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
    
  }

  public class Pastry
  {

  }
}

