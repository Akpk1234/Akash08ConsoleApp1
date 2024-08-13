//Question4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Q4
    {
        public static void Qs4()
    {
        int[] participantCodes = { 102, 215, 324, 453, 536 };
        int maleCount = 0;
        int femaleCount = 0;

        for (int  i = 0; i < participantCodes.Length; i++)
        {
            if(participantCodes[i] % 2 == 0)
            {
                maleCount++;
            }
            else
            {
                femaleCount++;
            }
        }

        Console.WriteLine("Number of male participants: " + maleCount);
        Console.WriteLine("Number of female participants: " + femaleCount);

        Console.ReadLine(); 

    }
    }
