using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {

        static void Main(string[] args)
        {

            //BubbleSort baloncuk sıralama bütün eleamnların üzerinden tekrar tekrar geçerek 
            //elemanlar arası değiş tokuş yapar


            int[] nums = { 1, 10, 22, 34, 54, 2, 5, 17, 4, 49 };
            Console.WriteLine("Sıralanmamış durum");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+", ");
            } 

            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < nums.Length-1; i++)
                {
                    if (nums[i]>nums[i+1])
                    {
                        int temp = nums[i + 1];

                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        swapped = true;
                    }

                }

            } while (swapped==true);
            Console.WriteLine();
            Console.WriteLine("Sıralamadan sonra");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+", ");
            }

        }
    }
}
