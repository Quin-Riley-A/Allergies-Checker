using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;
using System;
using System.Linq;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergensTests
  {
    [TestMethod]
    public void SickoZone_CallsListMakesMeSick_String()
    {
      Allergens testAllergens = new Allergens();

      Assert.AreEqual("", testAllergens.SickoZone(0));
    }
    [TestMethod]
    public void SickoZone_ReturnsAllergens_String()
    {
      Allergens testAllergens = new Allergens();

      Assert.AreEqual("eggs", testAllergens.SickoZone(1));
    }
    [TestMethod]
    public void SickoZone_ReturnsAllAllergens_String()
    {
      Allergens testAllergens = new Allergens();
      string[] reverseArray = Enumerable.Reverse(testAllergens.MakesMeSick).ToArray();
      Console.WriteLine(reverseArray);
      Console.WriteLine(testAllergens.MakesMeSick);
      string bigAllergensString = String.Join(' ', reverseArray);
      bigAllergensString = bigAllergensString.Replace(" ", ", ");
      Assert.AreEqual(bigAllergensString, testAllergens.SickoZone(255));
    }
  }
}