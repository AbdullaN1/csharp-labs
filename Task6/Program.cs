using System;

namespace Task6
{
    class Program
    {
        static string ConvertToLower(string text, out int upperCount)
        {
            upperCount = 0;
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string inputText;
            do
            {
                Console.Write("Жолды енгізіңіз: ");
                inputText = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(inputText));

            string convertedText = ConvertToLower(inputText, out int count);

            Console.WriteLine("Бастапқы жол: " + inputText);
            Console.WriteLine("Нәтиже жол:   " + convertedText);
            Console.WriteLine("Бас әріптер саны: " + count);
        }
    }
}