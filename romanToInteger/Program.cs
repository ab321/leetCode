/*

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.



   Example 1:

   Input: s = "III"
   Output: 3
   Explanation: III = 3.

   Example 2:

   Input: s = "LVIII"
   Output: 58
   Explanation: L = 50, V= 5, III = 3.

   Example 3:

   Input: s = "MCMXCIV"
   Output: 1994
   Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

      Symbol       Value
   I             1
   V             5
   X             10
   L             50
   C             100
   D             500
   M             1000



// Version 1

int RomanToInt(string s) {
   Dictionary<string, int> romanDigits = new Dictionary<string, int>()
   {
      {"I", 1 },
      {"V", 5},
      {"X", 10},
      {"L", 50},
      {"C", 100},
      {"D", 500},
      {"M", 1000}
   };
   
   int result = 0;

   var resultsArr = new int[s.Length];

   for (int i = 0; i < s.Length; i++)
   {
      romanDigits.TryGetValue(s[i].ToString(), out resultsArr[i]);
   }

   for (int i = 0; i < resultsArr.Length; i++)
   {
      if (i < resultsArr.Length - 1 && resultsArr[i] < resultsArr[i + 1])
      {
         result += (resultsArr[i + 1] - resultsArr[i]);
         i++;
      }
      else
      {
         result += resultsArr[i];
      }
   }

   return result;
}
*/

string input = "MCMXCIV";

Console.WriteLine(RomanToInt(input));

//Version 2

int RomanToInt(string s) {

   Dictionary<string, int> romanDigits = new Dictionary<string, int>()
   {
      {"I", 1 },
      {"V", 5},
      {"X", 10},
      {"L", 50},
      {"C", 100},
      {"D", 500},
      {"M", 1000}
   };
   
   int result = 0;

   for (int i = 0; i < s.Length; i++)
   {
      if (i < s.Length - 1 && romanDigits[s[i].ToString()] < romanDigits[s[i + 1].ToString()])
      {
         result -= romanDigits[s[i].ToString()];
      }
      else
      {
         result += romanDigits[s[i].ToString()];
      }
   }

   return result;
   
}