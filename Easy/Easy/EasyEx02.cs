using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx02
    {
        /**
         * The function to calculate the power value
         * agr01: number01: base number
         * arg02: number02: power number
         * return: the power number02 value of number01
         * **/
        public double Run(double[] array)
        {
            if (array.Length != 2)
            {
                Lib.Log("Invalid Input. Input array size must be 3");
                return 0;
            }
            double result = 1;

            for (int i = 0; i < Math.Abs(array[1]); i++)
            {
                result *= array[0];
            }
            if (array[1] < 0) return 1 / result;
            return result;
        }
    }
}
