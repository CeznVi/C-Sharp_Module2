using System;
using System.Linq;

namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////Завдання №1
            /////Оголосити одновимірний (5 елементів) масив з назвою
            ////A i двовимірний масив(3 рядки, 4 стовпці) дробових чисел
            ////з назвою B.Заповнити одновимірний масив А числами,
            ////введеними з клавіатури користувачем, а двовимірний
            ////масив В — випадковими числами за допомогою циклів.
            ////Вивести на екран значення масивів: масиву А — в один
            ////рядок, масиву В — у вигляді матриці.
            ///Знайти у даних масивах 
            ///загальний максимальний елемент, 
            ///мінімальний елемент, 
            ///загальну суму усіх елементів, 
            ///загальний добуток усіх елементів, 
            ///суму парних елементів масиву А, 
            ///суму непарних стовпців масиву В.

            int[] A = new int[5];

            Console.WriteLine($"Enter {A.Length} number:");

            for (int i = 0; i < A.Length; i++)
                A[i] = Int32.Parse(Console.ReadLine());

            float[,] B = new float[3, 4];

            Random r = new Random();
            
            for(int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = r.Next(1, 9) / (float)r.Next(2, 3);
                }
            }

            Console.Clear();
            Console.WriteLine("Masive A:");
            foreach (int i in A)
                Console.Write($"{i} \t");
            Console.WriteLine();

            Console.WriteLine("Masive B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Max element in massive A {A.Max()}");
            Console.WriteLine($"Min element in massive A {A.Min()}");
            Console.WriteLine($"Sum all element in massive A {A.Sum()}");
            Console.WriteLine($"Product all element in massive A {A.Count()}");

            float max = 0;
            float min = 0;
            float sum = 0;

            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        min = B[i, j];
                        max = B[i, j];
                    }
                    if(B[i, j] > max)
                        max = B[i, j];
                    if(B[i, j] < min)
                        min = B[i, j];
                    sum += B[i, j];
                }

            Console.WriteLine($"Max element in massive B {max}");
            Console.WriteLine($"Min element in massive B {min}");
            Console.WriteLine($"Sum all element in massive B {sum}");


            /*кінець завдання 1*/


        }
    }
}
