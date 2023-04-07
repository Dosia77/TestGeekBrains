using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeerBrainsTest
{
    internal class GeekTest
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[9] { "Gee", "kBr", "ain", "s", "20", "23", "Hello", "world", "!" };
            string[] arr2 = NewArray(arr1);
            PrintArray(arr1);
            PrintArray(arr2);

        }
    }
}
