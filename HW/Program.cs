using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //          7.8
            //Объявить массив из N чисел. (N вводится с клавиатуры).
            //Вывести на экран отдельно все четные и нечетные элементы массива.

            /*

            Console.Write("Enter the size of the array: ");
           int N = int.Parse(Console.ReadLine());

            int[] mas = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter the value of the {0} element: ", i);
                mas[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Even numbers of the array: ");

            bool b = true;

            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    b = true;
                    Console.Write(mas[i]);
                }
            }

            Console.Write("\nOdd numbers of the array: ");
            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 2 == 1)
                {
                    b = true;
                    Console.Write(mas[i]);
                }
            }
            */


 //          Задача 7.9
   //В заданном массиве найти минимальное и максимальное значение.
//Вывести на экран массив, после чего максимальное и минимальное 
//значение с указанием номера этих элементов в массиве.
// + sorting

            
            int[] mas = { 8, 24, 3, 1, 0, 35, 15 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(" {0}", mas[i]);
            }
            int min = mas[0];
            int max = mas[0];
            int numMin = 0;
            int numMax = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                    numMin = i;
                }
                if (mas[i] > max)
                {
                    max = mas[i];
                    numMax = i;
                }
            }
            Console.WriteLine("\n\nMinimum number: {0}. Element index: {1} ", min, numMin);
            Console.WriteLine("\nMaximum number: {0}. Element index: {1} \n", max, numMax);

            // sorting            
            /**/
            for (int j = 0; j < mas.Length; j++)
            {
                min = mas[j];

                for (int i = j; i < mas.Length; i++)
                {
                    if (mas[i] < min)
                    {
                        min = mas[i];
                        mas[i] = mas[j];
                        mas[j] = min;
                    }
                }
            }
            
                foreach (int x in mas) Console.Write(" {0}", x);



            Console.ReadLine();
        }
    }
}
