using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArifmaProgramm
    {
        static void Main(string[] args)
        {
            int n=0,d;

            //Getting data from user
            bool isInt = false;
            while (!isInt)
            {
                Console.Write("Please enter number of row values: ");
                isInt = int.TryParse(Console.ReadLine(), out n);
                if (!isInt)
                    Console.WriteLine("Type an integer value !");
            }

            int[] arrayOfX = new int[n];
            int[] arrayOfY = new int[n];
            for (int i=0; i<n; i++)
            {
                Console.Write($"Please enter value num {i+1}: ");
                int.TryParse(Console.ReadLine(), out arrayOfX[i]);
            }

            Console.Write("Please enter number fractional difference parameter(d):");
            int.TryParse(Console.ReadLine(), out d);


            //Сalculation
            for (int t = 1; t <= n; t++)
            {
                int sum = 0;
                for(int k = 1; k <= (t - 1); k++)
                {
                    int prod = 1;
                    for(int i = 1; i<= k; i++)
                    {
                        prod *= d - i + 1;
                    }
                    sum += (prod / factorial(k)) * arrayOfX[t - k - 1] * (int)Math.Pow(-1, k);
                }
                arrayOfY[t - 1] = sum + arrayOfX[t - 1];
            }


            //Output data
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i} pair: {arrayOfX[i]} : {arrayOfY[i]}");
            }


        }

        static int factorial(int n)
        {
            if (n == 1)
                return 1;
            return (n * factorial(n - 1));
        }
    }
}
