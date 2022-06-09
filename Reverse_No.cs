using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems;

     class Reverse_No
    {
       public void Reverse()
       {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            while (number > 0)
            {
              int a = number % 10;
              ans = ans * 10 + a;
              number = number / 10;

            }
            Console.WriteLine("\nReverse Number: " + ans);
       }
    }

