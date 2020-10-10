//Jeff Benson

//Tutorial From:
//https://www.c-sharpcorner.com/article/caesar-cipher-in-c-sharp/

using System;

namespace Caesar_Cipher
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        //Encipher method
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        //Decipher Method
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to encrypt: ");
            string UserString = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Encrypted Data");

            string cipherText = Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.WriteLine("\n");

            Console.WriteLine("Decrypted Data");

            string t = Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
