using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems;
class Febonacci
{
    public void Febonacci_Series()
    {
        Console.WriteLine("Enter a number");
        int series = Convert.ToInt32(Console.ReadLine());
        int previousValue = 0;
        int value = 1;
        int ans = 0;

        for (int i = 1; i <= series; i++)
        {
            ans = previousValue + value;
            previousValue = value;
            value = ans;

            Console.WriteLine(ans);
        }

    }
}

