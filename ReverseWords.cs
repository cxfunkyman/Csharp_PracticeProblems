using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ReverseWords
    {
        //Reverse a Single string with 3 different methods
        public static string Reverse(string word)
        {
            string reverse = "";
            int wordLength = word.Length;

            for(int i = wordLength; i > 0; i--)
            {
                reverse += word[i - 1];
            }
            return reverse;
        }

        public static string ReverseSecond(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        public static string ReverseThird(string word)
        {
            return new string(word.Reverse().ToArray());
        }

        //Reverse an Array of string
        public static string[] ArrayReverse(string[] word)
        {            
            string[] reverseArray = new string[4];

            int arrayLength;
            arrayLength = word.Length;

            for (int i = 0; i <= arrayLength - 1; i++)
            {
                string reverse = "";

                int wordLength;
                string singleWord = word[i];
                wordLength = singleWord.Length;
                

                for (int j = wordLength; j > 0; j--)
                {
                    reverse += singleWord[j - 1];
                }
                reverseArray[i] = reverse;

            }
            return reverseArray;
        }

    }
}
