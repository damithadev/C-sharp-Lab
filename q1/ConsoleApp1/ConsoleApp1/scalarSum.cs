using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class scalarSum
    {
        public scalarSum() 
        {
            int size;
            int sum1 = 0;
            int sum2 = 0;

            Console.Write("Enter the size of the array:");
            size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];


            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter element #" + (i + 1) + " for array 1: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Enter element #" + (i + 1) + " for array 2: ");
                array2[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 0; i < array1.Length; i++)
            {
                sum1 = sum1 + array1[i];
            }

            Console.WriteLine("The sum of the array is: " + sum1);

            for (int i = 0; i < array2.Length; i++)
            {
                sum2 = sum2 + array2[i];
            }

            Console.WriteLine("The sum of the array is: " + sum2);


           
        }
    }
}
