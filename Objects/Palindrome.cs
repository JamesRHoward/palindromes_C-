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
      int wordLength = word.Length;

      for (int i = 0; i < wordLength; i++)
      {
        if (inputWord[i] == inputWord [(word.Length -1) - i])
        {
          count ++;
        }
      }

      if (count == wordLength)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
