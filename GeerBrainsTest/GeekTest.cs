using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeerBrainsTest
{
    internal class GeekTest
    {
        static string[] NewArray(string[] array1)
        {
            string[] array2 = new string[array1.Length];
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <= 3)
                {
                    array2[count] = array1[i];
                    count++;
                }
            }
            return array2;
        }
        static void PrintArray(string[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write("]");

            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            string[] arr1 = new string[9] { "Gee", "kBr", "ain", "s", "20", "23", "Hello", "world", "!" };
            string[] arr2 = NewArray(arr1);
            PrintArray(arr1);
            PrintArray(arr2);
            Console.Readline();

        }
    }
}
