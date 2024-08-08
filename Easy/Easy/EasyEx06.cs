using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx06
    {
        /**
         * Total even numbers in array
         * Input: Array:an int array
         * Output: int Total even numbers
         * **/
        public int Run(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    total += array[i];
                }
            }
            return total;
        }
    }
}
