using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q8
{
    public static void Qs8()
    {
        int[] grades = { 56, 78, 89, 45, 67 };

        try
        {
            int secondSmallestGrade = FindSecondSmallest(grades);

            Console.WriteLine("The second smallest grade is: " + secondSmallestGrade);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static int FindSecondSmallest(int[] array)
    {
        if (array.Length < 2)
        {
            throw new InvalidOperationException("Array must contain at least two elements.");
        }

        int firstMin = int.MaxValue;
        int secondMin = int.MaxValue;

        foreach (int grade in array)
        {
            if (grade < firstMin)
            {
                secondMin = firstMin;
                firstMin = grade;
            }
            else if (grade < secondMin && grade != firstMin)
            {
                secondMin = grade;
            }
        }

        if (secondMin == int.MaxValue)
        {
            throw new InvalidOperationException("No second smallest element found. Array may contain duplicate elements.");
        }

        return secondMin;
    }
}
