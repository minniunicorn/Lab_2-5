using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_5
{
    class ArrayClass
    {
        /// <summary>
        /// Массив
        /// </summary>
        public int[] vs = new int[10];
        /// <summary>
        /// Максимальный элемент
        /// </summary>
        public int max;
        /// <summary>
        /// Минимальный элемент
        /// </summary>
        public int min;
        /// <summary>
        /// Индекс максимального элемента
        /// </summary>
        public int temp1;
        public static void Output(int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                Console.Write(vs[i] + " ");
            }
        }
        public static int Max(int[] vs, int max)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i]>max)
                {
                    max = vs[i];
                }
            }
            return max;
        }       
        public static int Min(int[] vs, int min)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] < min)
                {
                    min = vs[i];
                }
            }
            return min;
        }

        public static void Change(int[] vs, int max, int min, int temp1)
        {
            max = 0;
            min = 0;
            for (int i = 1; i < vs.Length; i++)
            {
                if (vs[i]<vs[min])
                {
                    min = i;
                }
                else
                {
                    if (vs[i]>vs[max])
                    {
                        max = i;
                    }
                }
            }
            temp1 = vs[min];
            vs[min] = vs[max];
            vs[max] = temp1;           
        }
        public static void Sorting (int[] vs)
        {
            for (int j = vs.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (vs[i] > vs[i + 1])
                    {
                        int temp2 = vs[i];
                        vs[i] = vs[i + 1];
                        vs[i + 1] = temp2;
                    }
                }
            }
        }

    }
}
