using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
//using System.Collections.Generic;

namespace Bakery.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadClass_CreateInstanceOfBread_Bread()
    {
      //Act
      Bread newBread = new Bread();

      //Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryClass_CreateInstancesOfPastry_Pastry()
    {
      //Act
      Pastry newPastry = new Pastry();

      //Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}