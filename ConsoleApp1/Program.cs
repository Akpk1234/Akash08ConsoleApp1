//Question_1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
            public class Program
    {
        static void Main(string[] args)
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int totalSum = 0;

            // Loop through each transaction and add it to totalSum
            for (int i = 0; i < transactions.Length; i++)
            {
                totalSum += transactions[i];
            }

            // Print the total sum
            Console.WriteLine("Total Sum of Transactions: " + totalSum);

            Q2.Qs2();
            Console.WriteLine();
            
            Q3.Qs3();
            Console.Read();

            Q4.Qs4();
            Console.WriteLine();

            Q5.Qs5();
            Console.WriteLine();

            Q6.Qs6();
            Console.WriteLine();

            Q7.Qs7();
            Console.WriteLine();

            Q8.Qs8();
            Console.WriteLine();

            Q9.Qs9();
            Console.WriteLine();

            Q10.Qs10();
            Console.WriteLine();
            Console.ReadLine();






        }

    }
}
