using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

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
  }
}