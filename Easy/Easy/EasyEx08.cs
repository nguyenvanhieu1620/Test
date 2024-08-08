using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx08
    {
        /**
         * Check if number is prime
         * Input: int number
         * Output: bool is prime or not prime
         * **/
        public bool Run(int number)
        {
            if (number == 2) return true;
            if (number <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
