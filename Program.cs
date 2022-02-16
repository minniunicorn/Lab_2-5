using System;

namespace Lab_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача на подпрограммы");

            /****ВЫВОД МАССИВА****/
            int[] array = new int[10];
            Random random = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(40);
            }
            ArrayClass.Output(array);
            Console.WriteLine();

            /****разность между максимальным и минимальным элементами массива****/
            int max = 0;
            int min = array[0];
            int temp1 = 0;
            max = ArrayClass.Max(array, max);
            min = ArrayClass.Min(array, min);
            Console.WriteLine("Max = " + max + ", Min = " + min);
            Console.WriteLine();
            int raz = max - min;
            Console.WriteLine("Разность между максимальным и минимаьным = " + raz);

            /****СОРТИРОВКА МАССИВА****/
            Console.WriteLine();
            ArrayClass.Change(array, max, min, temp1);
            Console.WriteLine("Массив, в котором максимальный и минимальный элементы поменялись местами");
            ArrayClass.Output(array);
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            ArrayClass.Sorting(array);
            ArrayClass.Output(array);
            Console.ReadKey();
        }
    }
}
