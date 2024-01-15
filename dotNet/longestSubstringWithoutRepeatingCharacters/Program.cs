

Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));

int LengthOfLongestSubstring(string s)
{

    /*if (s.Length == 0)
    {
        return 0;
    }

    bool contL = false;
    
    for (int i = 0; i < s.Length; i++)
    {
        if (Char.IsLetter(s[i]))
        {
            contL = true;
        }
    }

    if (!contL)
    {
        return 1;
    }
    
    
    
    public class Solution {
           public int LengthOfLongestSubstring(string s) {
               if (string.IsNullOrWhiteSpace(s))
                   return 0;
       
               char[] newArr = new char[s.Length];
               char[] endArray = new char[newArr.Length];
               int endArrayLength = 0;
               int newLength = 0;
       
               for (int i = 0; i < s.Length; i++) {
                   if (!newArr.Take(newLength).Contains(s[i])) {
                       newArr[newLength++] = s[i];
                   } else {
                       if (newLength > endArrayLength) {
                           endArray = newArr.Take(newLength).ToArray();
                           endArrayLength = newLength;
                       }
       
                       i -= newLength - 1;
                       newLength = 0;
                       newArr = new char[s.Length];
                   }
               }
       
               if (newLength > endArrayLength) {
                   endArray = newArr.Take(newLength).ToArray();
                   endArrayLength = newLength;
               }
       
               return endArrayLength;
           }
       }
       */

    if (string.IsNullOrWhiteSpace(s))
        return 0;
       
    char[] newArr = new char[s.Length];
    char[] endArray = new char[newArr.Length];
    int endArrayLength = 0;
    int newLength = 0;
       
    for (int i = 0; i < s.Length; i++) {
        if (!newArr.Take(newLength).Contains(s[i])) {
            newArr[newLength++] = s[i];
        } else {
            if (newLength > endArrayLength) {
                endArray = newArr.Take(newLength).ToArray();
                endArrayLength = newLength;
            }
       
            i -= newLength - 1;
            newLength = 0;
            newArr = new char[s.Length];
        }
    }
       
    if (newLength > endArrayLength) {
        endArray = newArr.Take(newLength).ToArray();
        endArrayLength = newLength;
    }
       
    return endArrayLength;
    
}