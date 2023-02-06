using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class PalindromeString
    {
        //Palindrome Check string
        public static bool PalindromeCheck(string words)
        {
            string word = words.ToLower();
            string reverse = "";
            int wordLength = word.Length;

            for (int i = wordLength; i > 0; i--)
            {
                reverse += word[i - 1];
            }

            if (reverse.Equals(word))
                return true;
            else
                return false;

        }

        public static bool PalindromeCheckSecond(string words)
        {
            string word = new string(words.ToLower().Reverse().ToArray());

            if (word.Equals(words))
                return true;
            else
                return false; 

        }
    }
}
