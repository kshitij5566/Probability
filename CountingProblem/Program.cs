using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            long k, n, x, res;
            char c;
            Console.WriteLine("Please enter the numbers between which you want to find the total numbers : \n");
            k = long.Parse(Console.ReadLine());
            n = long.Parse(Console.ReadLine());
            res = (n - k) + 1;

            Console.WriteLine("The answer is : {0}", res);
            Console.WriteLine("Do you want to find the total numbers divisible by 2 between these numbers : Y or N ?");

            c = char.Parse(Console.ReadLine());
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (c == 'y' || c == 'Y')
            {
                for (long i = k; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        k = i / 2;
                        break;
                    }
                }
                for (long i = n; i >= k; i--)
                {
                    if (i % 2 == 0)
                    {
                        n = i / 2;
                        break;
                    }
                }
                res = (n - k) + 1;
                Console.WriteLine("The answer is : {0}", res);
            }
            else
            {
                Console.WriteLine("Thank You !!  Press any key to continue....\n");
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("The time taken is : {0}", elapsedMs);

            Console.ReadKey();

        }
    }
}
