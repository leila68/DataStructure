using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortArray
{
    class Program
    {
        public static void sort(ref int[] array)
        {
            int temp;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
          
            

        }
        static void Main(string[] args)
        {
            int[] array = new int[8] {2,12,7,3,15,29,12,17 };
            sort(ref array);
          //  int[] array1 = new int[5];


            for (int x = 0; x < array.Length; x++)
            {

                Console.WriteLine(array[x]);
            }
            
            Console.ReadKey(); 
        }
    }
}
