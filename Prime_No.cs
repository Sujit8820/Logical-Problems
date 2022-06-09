using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems;

    class Prime_No
    {
        public void Prime()
        {
            Console.WriteLine("Enter no you want to check: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool Prime = true;

            for (int i = 2; i < number; i++)
            {
                int remainder = number % i;

                if (remainder == 0)
                {
                    Prime = false;
                }
            }

            if (Prime == true)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else if (Prime == false)
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }
    }

