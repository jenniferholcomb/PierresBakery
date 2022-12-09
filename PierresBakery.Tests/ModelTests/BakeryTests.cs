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
  }
}