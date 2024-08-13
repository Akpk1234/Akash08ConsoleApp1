//Question3

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q3
{
    public static void Qs3()
    {
        int maxnum = 0;
        int[] prices = { 1500, 2300, 999, 3200, 1750 };
        for (int i = 0; i < prices.Length; i++) 
        {
            if (prices[i] > maxnum)
            {
                maxnum = prices[i];
            }
           /* else 
            {

            }*/
                    
        }
        Console.WriteLine("Answer 3:"+ maxnum);
    }
}


