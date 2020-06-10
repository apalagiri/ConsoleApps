using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        void reverse_words_string(string str)
        {
            string[] strarray = str.Split(" ");
            Array.Reverse(strarray);
            str = string.Join(" ", strarray);

           // for (int i = 0; i < strarray.Length; i++)

              //  Console.WriteLine(strarray[i]);

            Console.WriteLine("Reversed words in a String: " +str);
        }
        void reverse_char_word_string(string str)
        {
            string[] strarray = str.Split(" ");
            for (int i = 0; i < strarray.Length; i++)
            {
                char[] word = strarray[i].ToCharArray();
                Array.Reverse(word);
                strarray[i] = new string (word);
                
            }
            str = string.Join(" ", strarray);
            Console.WriteLine("Reversed words in a String: " + str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to reverse the words:");
            string s = Console.ReadLine();
            Program p = new Program();
            p.reverse_words_string(s);
            p.reverse_char_word_string(s);

        }
    }
}
