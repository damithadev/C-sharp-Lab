using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class vectorSum
    {
        public void vectorsum()
        {
            int size;

            Console.Write("Enter the size of the array:");
            size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];
            int[] array3 = new int[size];


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
                array3[i] = array1[i] + array2[i];
            }

            Console.WriteLine("The elements of the result array are:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }



        }


    }
}
