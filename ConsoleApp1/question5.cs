//Question5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q5
{
    public static void Qs5()
    {
        int[] searchHistory = { 101, 202, 303, 404, 505 };

        Console.WriteLine("Original Search History:");
        PrintArray(searchHistory);

        ReverseArray(searchHistory);

        Console.WriteLine("Reversed Search History:");
        PrintArray(searchHistory);
    }

    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
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


