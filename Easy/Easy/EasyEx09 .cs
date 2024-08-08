using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx09
    {
        /**
         * find the remainder a divided by b
         * Input:  Array: in int array
         * Output: int remainder
         * **/
        public int Run(int[] array)

        {
            if (array.Length != 2)
            {
                Lib.Log("Invalid Input. Input array size must be 3");
                return 0;
            }

            if (array[1] == 0)
            {
                Lib.Log("Invalid Input. Input divisor is 0");
                return 0;
            }
            while (array[0] >= array[1])
            {
                array[0] -= array[1];
            }
            return array[0];
        }
    }
}
