using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.sum_using__while__loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 1;

            while (i <= 50)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum from 1 to 50 is: " + sum);

        }
    }
}
