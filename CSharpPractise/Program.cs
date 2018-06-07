using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var isValidEntry = false;
            string word = "";

            while (!isValidEntry)
            {
                Console.WriteLine("Please enter a word to see if it is a palindrome.");
                word = Console.ReadLine();
            }

            if (IsPalindrome(word))
            {
                Console.WriteLine("The word you have entered is a palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The word you have entered is not a palindrome");
                Console.ReadLine();
            }
        }

        public static bool IsPalindrome(string word)
        {
            var charList = new List<char>(word);
            var reverseList = new List<char>();

            for (var x = charList.Count - 1; x >= 0; x--)
            {
                reverseList.Add(charList[x]);           
            }
            
            return (reverseList.SequenceEqual(charList)) ? true : false;
        }
    }
}
