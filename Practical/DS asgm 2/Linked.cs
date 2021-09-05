using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace DS_asgm_2
{

    public class Node
    {
        public String data;
        public Node next;

        public Node(String d)
        {
            data = d;
            next = null;
        }
    }

    public class LinkedList_Palindrome
    {
        public Node head;


        bool isPalidromeUtil(String str) // check if string is palindrome
        {
            int length = str.Length;


            for (int i = 0; i < length / 2; i++) // match char from beginning and end 
                if (str[i] != str[length - i - 1])
                    return false;

            return true;
        }


        public bool isPalindrome()
        {
            Node node = head;


            String str = ""; // form a string 
            while (node != null)
            {
                str = str + (node.data);
                node = node.next;
            }


            return isPalidromeUtil(str);
        }
    }
}
