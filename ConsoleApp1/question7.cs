using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q7
{
    public static void Qs7()
    {
        int[] bookCodes = { 101, 203, 304, 405, 506 };
        int searchCode = 304;

        int index = FindBookByCode(bookCodes, searchCode);

        if (index != -1)
        {
            Console.WriteLine($"Book code {searchCode} found at index: {index}");
        }
        else
        {
            Console.WriteLine($"Book code {searchCode} not found.");
        }
    }

    static int FindBookByCode(int[] array, int code)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == code)
            {
                return i;
            }
        }
        return -1;
    }
}
