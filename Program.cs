using System;

namespace Palíndromos
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            Console.WriteLine("Palíndromos");
            Console.Write("Escriba una palabra para verificar si es un palíndromo: ");
            string inputStr = Console.ReadLine();
            Console.WriteLine("La palabra es un palíndromo: " + isPalindrome(inputStr));
            Console.ReadKey();
            Console.Clear();
            goto a;
        }

        public static bool isPalindrome(string inputStr)
        {
            char[] chars = inputStr.ToCharArray();  // Arreglo para guardar la palabra e invertirlo
            string reverseWord = "";
            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                reverseWord = reverseWord + chars[i];  // Se guarda cada carácter de la palabra invertida
            }

            if (reverseWord == inputStr)     // Si la palabra invertida es igual a la palabra original es un palíndromo
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
