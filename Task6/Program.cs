using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            do
            {
                Console.Write("Жолды енгізіңіз: ");
                inputText = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(inputText));

            Console.WriteLine("Бастапқы жол: " + inputText);
        }
    }
}