using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace DS_asgm_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<char> palindromeStack = new Stack<char>();
            Console.WriteLine("Enter a word to check if it's palindrome");
            string input = Console.ReadLine().ToUpper();

            input = Regex.Replace(input, "[^A-Z0-9]", "");
            foreach (char c in input)
            {
                palindromeStack.Push(c);
            }

            bool palindrome = true;
            foreach (char c in input)
            {
                if (c != palindromeStack.Pop())
                {
                    palindrome = false;
                    break;
                }
            }
            Console.WriteLine(palindrome ? "This is palindrome" : "This is not the palindrom");




            Queue<char> palindromeQueue = new Queue<char>();
            Console.WriteLine("Enter a word to check if it's palindrome");
            string text = Console.ReadLine().ToUpper();

            text = Regex.Replace(input, "[^A-Z0-9]", "");
            foreach (char c in text)
            {
                palindromeQueue.Enqueue(c);
            }

            bool palindromeQ = true;
            foreach (char c in text)
            {
                if (c != palindromeQueue.Dequeue())
                {
                    palindromeQ = false;
                    break;
                }
            }
            Console.WriteLine(palindromeQ ? "This is palindrome" : "This is not the palindrom");




            Console.WriteLine("Enter a word to check if it's palindrome");
            string inputLL = Console.ReadLine().ToUpper();


            inputLL = Regex.Replace(inputLL, "[^A-Z0-9]", "");

            LinkedList_Palindrome list = new LinkedList_Palindrome();
            list.head = new Node(inputLL);


            Console.WriteLine(list.isPalindrome() ? "This is palindrome" : "This is not the palindrom");



        }


    }
}