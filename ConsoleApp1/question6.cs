//Question6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Q6
    {
        public static void Qs6()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;

            Console.WriteLine("Original Measurements:");
            PrintArray(measurements);

            AdjustMeasurements(measurements, factor);

            Console.WriteLine("Adjusted Measurements:");
            PrintArray(measurements);
        }

        static void AdjustMeasurements(int[] array, int factor)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= factor;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }