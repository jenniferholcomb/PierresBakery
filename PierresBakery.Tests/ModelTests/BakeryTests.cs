using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
//using System.Collections.Generic;

namespace PierresBakery.Test
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
    public void PastryClass_CreateInstanceOfPastry_Pastry()
    {
      //Act
      Pastry newPastry = new Pastry();

      //Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void BakeryClass_CreateInstanceOfBakery_Bakery()
    {
      //Act
      Bakery newBakery = new Bakery();

      //Assert
      Assert.AreEqual(typeof(Bakery), newBakery.GetType());
    }

    [TestMethod]
    public void OrderFilter_IdentifiesIfBreadPastryBoth_String()
    {
      //Arrange
      int breadCount = 2;
      int pastryCount = 0;
      Bakery newBakery = new Bakery();
      string order = "bread";

      //Act
      string result = newBakery.OrderFilter(breadCount, pastryCount);

      //Assert
      Assert.AreEqual(order, result);
    }
  }
}