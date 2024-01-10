/*
   Given an integer x, return true if x is a palindrome, and false otherwise.

   Example 1:

   Input: x = 121
   Output: true
*/



//Version 1

/*
bool IsPalindrom(int x)
{
   if (x >= 0)
   {
      int maxLength = x.ToString().Length - 1;
      string input = x.ToString();

      for (int i = 0; i < maxLength+1; i++)
      {
         if (input[i] != input[maxLength - i])
            return false;
      }

      return true;
   }

   return false;
}
*/


//Version 2

bool IsPalindrom(int x)
{
   if (x >= 0)
   {
      int[] numbArr = new int[x.ToString().Length];
      int[] numbArr2 = new int[x.ToString().Length];

      for (int i = 0; i < x.ToString().Length; i++)
      {
         numbArr[i] = x.ToString()[i] - 48;
      }

      int counter = 0;

      for (int i = x.ToString().Length - 1; i >= 0; i--)
      {
         numbArr2[counter] =  (int) x.ToString()[i] - 48;
         counter++;
      }

      for (int i = 0; i < numbArr.Length; i++)
      {
         if (numbArr[i] != numbArr2[i])
         {
            return false;
         }
      }

      return true;
   }
   else
   {
      return false;
   }
}