using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nomer = 9; // Тізім номеры
            int n = 5;
            int[,] matrix = new int[n, n];
            Random rnd = new Random(nomer);

            // Матрицаны толтыру
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                }
            }

            Console.WriteLine("5x5 Матрица:");
            PrintMatrix(matrix);

            // Есептеу методын шақыру
            int[] resultArray = GetNegativeRowIndicators(matrix);

            // B массивін экранға шығару
            Console.WriteLine("\nB[5] массивінің нәтижесі:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine($"B[{i}] = {resultArray[i]}");
            }
        }

        // Матрицаны экранға кесте түрінде шығаратын жеке метод
        static void PrintMatrix(int[,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{m[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        // 2-нұсқа: Егер жолда кемінде бір теріс элемент болса 1, әйтпесе 0 қайтаратын метод
        static int[] GetNegativeRowIndicators(int[,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);
            int[] b = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                b[i] = 0; 

                for (int j = 0; j < cols; j++)
                {
                    if (m[i, j] < 0)
                    {
                        b[i] = 1; 
                        break;    
                    }
                }
            }

            return b;
        }
    }
}