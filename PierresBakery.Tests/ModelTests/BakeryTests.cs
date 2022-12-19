using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadClass_CreateInstanceOfBread_Bread()
    {
      //Act
      Bread newBread = new Bread(2);

      //Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void CalculateTotal_CalculatesTotalBreadOrder_Int()
    {
      //Arrange
      int breadCount = 4;
      int orderTotal = 15;

      //Act
      Bread newBread = new Bread(breadCount);
      int result = newBread.CalculateTotal();

      //Assert
      Assert.AreEqual(orderTotal, result);
    }

    [TestMethod]
    public void PastryClass_CreateInstanceOfPastry_Pastry()
    {
      //Act
      Pastry newPastry = new Pastry(1);

      //Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CalculateTotal_CalculatesTotalPastryOrder_Int()
    {
      //Arrange
      int pastryCount = 4;
      int orderTotal = 7;

      //Act
      Pastry newPastry = new Pastry(pastryCount);
      int result = newPastry.CalculateTotal();

      //Assert
      Assert.AreEqual(orderTotal, result);
    }

    [TestMethod]
    public void BakeryClass_CreateInstanceOfBakery_Bakery()
    {
      //Act
      Bakery newBakery = new Bakery();

      //Assert
      Assert.AreEqual(typeof(Bakery), newBakery.GetType());
    }

    // [TestMethod]
    // public void Order_ReturnsEmptyDictionary_True()
    // {
    //   //Arrange
    //   Bakery newBakery = new Bakery();
    //   Dictionary<string, int[]> bakeryOrder = new Dictionary<string, int[]>() 
    //   {
    //     { "bread", new int[2] },
    //     { "pastries", new int[2] }
    //   };

    //   //Act
    //   Dictionary<string, int[]> result = newBakery.bakeryOrder;

    //   //Assert
    //   CollectionAssert.AreEqual(bakeryOrder, result);
    // }

    // [TestMethod]
    // public void Order_IdentifiesIfBreadPastryBothAddedToDictionary_Dictionary()
    // {
    //   //Arrange
    //   int breadCount = 4;
    //   int pastryCount = 4;
    //   Bakery newBakery = new Bakery();
    //   Dictionary<string, int[]> bakeryOrder = new Dictionary<string, int[]>() {
    //     {"bread", new int[]{4, 15}},
    //     {"pastries", new int[]{4, 7}}
    //   };

    //   //Act
    //   newBakery.Order(breadCount, pastryCount);
    //   Dictionary<string, int[]> result = newBakery.bakeryOrder;

    //   //Assert
    //   CollectionAssert.AreEqual(bakeryOrder, result);
    // }

    [TestMethod]
    public void PrintOrder_ReturnsBreadPastryTotalToUser_String()
    {
      //Arrange
      int breadTotal = 4;
      int pastryTotal = 4;
      Bakery newBakery = new Bakery();
      string orderTotal = "Your order total for 4 loaves of bread is $15, and 4 pastries is $7. You owe $22.";

      //Act
      newBakery.Order(breadTotal, pastryTotal);
      string result = newBakery.PrintOrder();

      //Assert
      Assert.AreEqual(orderTotal, result);
    }
  }
}

    // [TestMethod]
    // public void Order_CreatesNewBreadClass_String()
    // {
    //   //Arrange
    //   int breadCount = 2;
    //   int pastryCount = 0;
    //   Bakery newBakery = new Bakery();

    //   //Act
    //   string result = newBakery.Order(breadCount, pastryCount);

    //   //Assert
    //   Assert.AreEqual(orderTotal, result);
    // }

    // [TestMethod]
    // public void Order_CreatesNewBakeryClass_String()
    // {
    //   //Arrange
    //   int breadCount = 0;
    //   int pastryCount = 1;
    //   Bakery newBakery = new Bakery();

    //   //Act
    //   string result = newBakery.Order(breadCount, pastryCount);

    //   //Assert
    //   Assert.AreEqual(orderTotal, result);
    // }

    // [TestMethod]
    // public void Order_AddsOrderToDictionary_True()
    // {
    //   //Arrange
    //   int breadCount = 4;
    //   int pastryCount = 4;
    //   Dictionary<string, int[]> bakeryOrder = new Dictionary<string, int[]>() {
    //     {"bread", new int[2]{breadCount, 15}},
    //     {"pastries", new int[2]{pastryCount, 7}}
    //   };
    //   int[] test3 = bakeryOrder["bread"];
    //   Bakery newBakery = new Bakery();

    //   //Act
    //   newBakery.Order(breadCount, pastryCount);
    //   Dictionary<string, int[]> result = newBakery.bakeryOrder;
    //   // Console.WriteLine(bakeryOrder);
    //   int[] test = result["bread"];
    //   int[] test2 = result["pastries"];
    //   // Console.WriteLine(test[0]);
    //   // Console.WriteLine(test2[0]);

    //   //Assert
    //   Assert.AreEqual(test3[0], test[0]);
    // }