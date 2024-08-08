using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx12
    {
        /**
         * Average numbers in array
         * Input: double array
         * Output: Average numbers in array
         * **/
        public double Run(double[] array)
        {
            if (array.Length <= 0)
            {

                Lib.Log("Invalid Input. Input array size must be greater than 0 ");
                return -1;

            }
            double total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total / array.Length;
        }
    }
}
