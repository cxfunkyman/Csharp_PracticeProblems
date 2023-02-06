// See https://aka.ms/new-console-template for more information
using PracticeProblems;
using System.Diagnostics;

bool loop = true;

while (loop)
{
    Console.WriteLine("Welcome to my Practice. \nPlease Select an Option:\n");
    Console.WriteLine("1 - Reverse single string. \n2 - Reverse multiples String");
    Console.WriteLine("3 - Palindrome Check. \n4 - Multiples Palindrome Check");
    Console.WriteLine("5 - Print the first 100 EMIRPs numbers starting from 100. \n6 - Perfect Number");

    int option = Convert.ToInt32(Console.ReadLine());    

    switch (option)
    {
        case 1:
            Console.WriteLine("Please enter the word to reverse: ");
            string word = Console.ReadLine();
            string reverseWord = ReverseWords.Reverse(word);
            string reverseWordSecond = ReverseWords.ReverseSecond(word);
            string reverseWordThird = ReverseWords.ReverseThird(word);

            Console.WriteLine("Reverse with For Loop: ");
            Console.WriteLine(reverseWord);
            Console.WriteLine("Reverse with Array.Reverse: ");
            Console.WriteLine(reverseWordSecond);
            Console.WriteLine("Reverse with word.Reverse().ToArray(): ");
            Console.WriteLine(reverseWordThird);
            Console.WriteLine("\n");

            break;

        case 2:
            Console.WriteLine("Please enter the words to reverse max 5 words,");
            Console.WriteLine("Separate with space: ");
            string[] wordArray = Console.ReadLine().Split(' ');
            Console.WriteLine("\n");

            string[] reverseArray = ReverseWords.ArrayReverse(wordArray);

            for (int i = 0; i <= reverseArray.Length - 1; i++)
            {
                Console.WriteLine(reverseArray[i]);
            }
            Console.WriteLine("\n");
            break;

        case 3:
            Console.WriteLine("Please enter the word to check if is a Palindrome: ");
            string str = Console.ReadLine();
            bool answer1 = PalindromeString.PalindromeCheck(str);
            bool answer2 = PalindromeString.PalindromeCheckSecond(str);

            if (answer1 && answer2)
                Console.WriteLine(str + " is a Palindrome");
            else
                Console.WriteLine(str + " is not a Palindrome");
            break;

        case 4:
            Console.WriteLine("Please enter the words to check if are Palindromes,");
            Console.WriteLine("Separate with space: ");
            string[] strArray = Console.ReadLine().Split(' ');
            Console.WriteLine("\n");
            
            for(int i = 0; i <= strArray.Length - 1; i++)
            {
                bool ans1 = PalindromeString.PalindromeCheck(strArray[i]);
                bool ans2 = PalindromeString.PalindromeCheckSecond(strArray[i]);

                if (ans1 && ans2)
                    Console.WriteLine(strArray[i] + " is a Palindrome");
                else
                    Console.WriteLine(strArray[i] + " is not a Palindrome");
            }
            break;

        case 5:
            int counter = 0, reverse = 0;
            bool prime = true;

            for(int i = 100; counter <= 100; i++)
            {
                prime = EMIRPnumber.PrimeNumber(i);

                if (prime)
                {
                    reverse = EMIRPnumber.EMIRPnumberCheck(i);
                    prime = EMIRPnumber.PrimeNumber(reverse);

                    if (prime)
                    {
                        Console.WriteLine(i + " is an EMIRP.");
                            counter++;
                    }
                }
            }
            break;

        case 6:
            Console.WriteLine("Please enter the Number to check if is a Perfect Number: ");
            Int64 numb = Convert.ToInt64(Console.ReadLine());

            if(PerfectNumber.PerfectNumberFirstApproach(numb))
                Console.WriteLine(numb + " is a perfect number. (PerfectNumberFirstApproach)");
            else
                Console.WriteLine(numb + " is not a perfect number. (PerfectNumberFirstApproach)");

            if (PerfectNumber.PerfectNumberSecondApproach(numb))
                Console.WriteLine(numb + " is a perfect number. (PerfectNumberSecondApproach)");
            else
                Console.WriteLine(numb + " is not a perfect number. (PerfectNumberSecondApproach)");

            break;

        default:
            Console.WriteLine("Option not found!!\n");
            break;
    }
    Console.WriteLine("\nDo you want to continue:\n1-Yes\n2-No");
    int yesNo = Convert.ToInt32(Console.ReadLine());

    if (yesNo == 2)
        loop = false;
    else
        loop = true;

    Console.WriteLine("\n");
}








