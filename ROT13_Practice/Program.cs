//Developer: Jeff Benson
//ROT13 Algorithm inspired by tutorial from dotnetpearls.com/rot13

using System;

namespace Rot13_Cipher_Practice
{
    class Program
    {
        static string Rot13(string input)
        {
            input = input.ToLower();
            char[] array = input.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];
                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your phrase to be encoded: ");
            string phrase = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Cipher text: " + Rot13(phrase));
            Console.ReadKey();
        }
    }
}
