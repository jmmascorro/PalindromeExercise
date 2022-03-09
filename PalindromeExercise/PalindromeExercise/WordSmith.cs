using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);

            if(reversed == text)
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
