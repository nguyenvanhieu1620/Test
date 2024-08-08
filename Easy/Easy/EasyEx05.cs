using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx05
    {
        /**
         * Count the total number of the even numbers in an array
         * input: array: an int array
         * return: int: the total number of the old numbers in the input array
         * **/
        public int Run(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
