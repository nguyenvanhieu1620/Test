using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx15
    {
        /**
         * calculate n factorial
         * input: int number
         * output: n factorial
         * **/
        public int Run(int number)
        {
            if (number < 0)
            {
                Lib.Log("Invalid Input. Number must be greater than 0 ");
                return -1;
            }
            if (number == 0 || number == 1) return 1;
            return number * Run(number - 1);
        }
    }
}
