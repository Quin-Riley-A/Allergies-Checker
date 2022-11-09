using System;

namespace Allergies
{
  public class Allergens
  {
    public string[] MakesMeSick = {"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"};
    public string SickoZone(int score)
    {
      //loop starts at last index
      //tries to subtract 2^(index) from the score
      //if it can it does and adds that allergen to the output string
      //else it iterates down one index and repeats

      //***Maybe make an empty array with a length equal to MakesMeSick.Length***
      //And push the string at the given index to the new array
      //stringify the new array and return
      
      int lengthOfSick = MakesMeSick.Length;
      string userAllergyStr = "";
      for(int i = lengthOfSick - 1; i >= 0; i--) 
      {
        double allergenValue = Math.Pow(2, i);
        int intAllergenValue = Convert.ToInt32(allergenValue);
        if (score > intAllergenValue)
        {
          score -= intAllergenValue;
          userAllergyStr = userAllergyStr + MakesMeSick[i] + ", ";
        }
      }
      return userAllergyStr;
    }
  }
}