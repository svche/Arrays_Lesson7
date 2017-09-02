using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Arrays_2908
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string person0 = "Ivan";
            int age0 = 10;

            string person1 = "Vova";
            int age1 = 15;

            Console.WriteLine("Name: {0}, age: {1}", person0, age0);
            Console.WriteLine("Name: {0}, age: {1}", person1, age1);
            Console.WriteLine("_______________________________");

            string[] persons = { "Ivan", "Vova", "Sveta" };
            int[] ages = { 10, 15, 12 };
            

            //Console.WriteLine("Name: {0}, age {1}", persons[0], ages[0]);
            //Console.WriteLine("Name: {0}, age {1}", persons[1], ages[1]);
            //Console.WriteLine("Name: {0}, age {1}", persons[2], ages[2]);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name: {0}. Age: {1}", persons[i], ages[i]);
            }
            */
            /*
   //          Задача 7.3
   //Для задачи 7.1 создать резервный массив, куда переписать значения из первого массива в обратном порядке.
            {
                int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i] + " ");
                }
                Console.WriteLine();


                int[] masNew = new int[mas.Length];

                for (int i = 0; i < mas.Length; i++)
                {
                    masNew[i] = mas[mas.Length - 1 - i];
                }
                for (int i = 0; i < masNew.Length; i++)
                {
                    Console.Write(masNew[i] + " ");
                }
            }
            */
            //         Задача 7.4
            //Ввести с клавиатуры количество студентов, объявить массив целых чисел для хранения роста студента. 
            //Посчитать средний рост и вывести на экран.
            /*
            int N;
            Console.Write("Input count of students: ");
            N = int.Parse(Console.ReadLine());

            int[] rost = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Input height of {0} students: ", i + 1);
                rost[i] = int.Parse(Console.ReadLine()); 
            }

            double srRost = 0;

            for (int i = 0; i < N; i++)
            {
                srRost = srRost + rost[i];
            }

            srRost = srRost / N;

            Console.WriteLine("Average height of the student is: {0}", srRost);
            */

            //         Задача 7.6
            //Создать матрицу. Заполнить ее числами, равными сумме номеров строки столбцов.
            //Вывести матрицу на экран.

            /* 

            int N = 10;

            int[,] matrix = new int[N, N];

            for (int i = 0; i <N; i++)
            {
                matrix[i, i] = 1;
            }

            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.Write(matrix[j, i] + " ");
                }
                Console.WriteLine();
            }
            */


   //         Задача 7.7
   //Создать матрицу для треугольника паскаля.Вывести ее на экран.
/*
            int n = 9;

            int[][] PT = new int[n][];

            for (int i = 0; i < n; i++)
            {
                PT[i] = new int[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        PT[i][j] = 1;
                    } else
                    {
                    PT[i][j] = PT[i-1][j-1] + PT[i-1][j];
                    }
                Console.Write(PT[i][j] + " ");
                }
                Console.WriteLine();
            }
*/
            



            Console.ReadLine();

        }
    }
}
