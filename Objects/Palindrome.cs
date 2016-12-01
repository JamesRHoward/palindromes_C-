using System;
using System.Collections.Generic;

namespace Palindrome.Object
{
  public class IsPalindrome
  {
    public static bool PalindromeChecker(string word)
    {
      int count = 0;
      char[] inputWord = word.ToCharArray();
      int inputWord = word.Length;

      for (i = 0; i < inputWord.Length; ++)
      {
        if (inputWord[i] == word.Length(word.Length -1) i - 1)
        {
          count ++;
        }
      }
      
    }
  }
}
