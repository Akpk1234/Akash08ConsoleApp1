using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Q10
{
    public static void Qs10()
    {
        int[] dataset1 = { 1, 2, 3, 4, 5 };
        int[] dataset2 = { 3, 4, 5, 6, 7 };

        Console.WriteLine("Dataset 1:");
        PrintArray(dataset1);

        Console.WriteLine("Dataset 2:");
        PrintArray(dataset2);

        int[] commonElements = FindCommonElements(dataset1, dataset2);

        Console.WriteLine("Common Elements:");
        PrintArray(commonElements);
    }

    static int[] FindCommonElements(int[] array1, int[] array2)
    {
        List<int> commonList = new List<int>();

        foreach (int element1 in array1)
        {
            foreach (int element2 in array2)
            {
                if (element1 == element2 && !commonList.Contains(element1))
                {
                    commonList.Add(element1);
                    break; // No need to continue inner loop if we found a common element
                }
            }
        }

        return commonList.ToArray();
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
