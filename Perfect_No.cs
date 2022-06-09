using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems;


     class Perfect_No
    {
        public bool Factors(int Number,int Potential_factor)
        {
            if(Number % Potential_factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void perfectnum()
        {
            int check = 0;
            
            Console.WriteLine("Enter no you want to check: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= Number/ 2; i++)
            {
                if(Factors(Number,i))
                {
                    check += i;
                }

            }
            if(check == Number)
            {
                Console.WriteLine(Number + " is a perfect number.");
            }
            else
            {
                Console.WriteLine(Number + " is not a perfect number");
            }
                
        }
    }


