using System;
using System.Collections.Generic;
using Xunit;
using Palindrome.Object;

namespace PalindromeTest
{
  public class IsPalindromeTest
  {
    [Fact]
    public void Palindrome_TestPalindromeChecker()
    {
      string wordInput = "tacocat";
      bool answer = true;
      bool testOutput = IsPalindrome.PalindromeChecker(wordInput);
      Assert.Equal(answer, testOutput);
    }
  }
}
