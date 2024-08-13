using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q9
{
    public static void Qs9()
    {
        int[] ids = { 102, 215, 102, 324, 215 };

        Console.WriteLine("Original IDs:");
        PrintArray(ids);

        int[] uniqueIds = RemoveDuplicates(ids);

        Console.WriteLine("Unique IDs:");
        PrintArray(uniqueIds);
    }

    static int[] RemoveDuplicates(int[] array)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> uniqueList = new List<int>();

        foreach (int id in array)
        {
            if (!seen.Contains(id))
            {
                seen.Add(id);
                uniqueList.Add(id);
            }
        }

        return uniqueList.ToArray();
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