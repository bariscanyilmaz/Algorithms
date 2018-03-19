using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertionSort ekleme/sokam sıralama
            //ikinci elemandan başlayarak iteretor kendinden önceki elemanlar ile karşılaştırır.

            int[] arr = { 10, 0, 9, 5, 2, 3, 6, 1, 7, 4 };
            Console.WriteLine("Sıralanmadan önce");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }

            int newValue;

            for (int i = 1; i < arr.Length; i++)
            {
                newValue = arr[i];

                int j = i;

                while (j>0 && arr[j-1]>newValue)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = newValue;
            }
            Console.WriteLine();
            Console.WriteLine("sıralamadan Sonra:");
            foreach (int item in arr)
            {
                Console.Write(item+",");
            }

        }
    }
}
