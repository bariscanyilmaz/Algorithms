using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //selection sort seçme sıralama
            //min eleamn ilk eleman seçilir kendinden sonraki elemanlar 
            //arasındaki en küçük ile yer değiştirilir
            int[] arr = { 5,2, 9, 6, 1, 3, 7 };

            //Sıralamadan önce
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }
            Console.WriteLine();

            int temp, minPosition;
            for (int i = 0; i < arr.Length-1; i++)
            {
                minPosition = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j]<arr[minPosition])
                    {
                        minPosition = j;
                    }
                }

                if (minPosition!=i)
                {
                    temp = arr[i];
                    arr[i] = arr[minPosition];
                    arr[minPosition] = temp;
                }

            }

            Console.WriteLine("Sıralamadan sonra");

            foreach (int item in arr)
            {
                Console.Write(item+",");
            }

        }
    }
}
