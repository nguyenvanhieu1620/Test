using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx11
    {
        /**
         * Find min value in array
         * Input: Int Array
         * Output: min value in array
         * **/
        public int Run(int[] array)
        {
            if (array.Length <= 0)
            {

                Lib.Log("Invalid Input. Input array size must be greater than 0 ");
                return -1;

            }
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
    }
}
