using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace getArray
{
    class Program
    {
        
        public static int maxArray(int[] iarray, ref  int index)
        {
            // int[] iarray = new int[5];
           int max = 0;
            for (int i = 0; i < iarray.Length; i++)
            {
                if (iarray[i] >= max)
                {
                    max = iarray[i];
                    index = i;
                }
            }


            return (max);

        }
        public static int minArray(int[] iarray, ref  int index)
        {
            // int[] iarray = new int[5];
            int min = iarray[0];
            for (int i = 0; i < iarray.Length; i++)
            {
                if (iarray[i] <= min)
                {
                    min = iarray[i];
                    index = i;
                }
            }


            return (min);

        }

        static void Main(string[] args)
        {
            int temp=0;
            int[] iarray = new int[5]{100,115,20,17,2};

            int max = maxArray(iarray,ref temp);
            Console.WriteLine("maximum :{0} ", max);
            Console.WriteLine("index :{0}", temp );

            int min = minArray(iarray, ref temp);
            Console.WriteLine("minimum :{0} ", min);
            Console.WriteLine("index :{0}", temp);

            Console.ReadKey();
        }
    }
}
