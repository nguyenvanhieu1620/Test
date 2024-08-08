using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx14
    {
        /**
         * Find first position number in arrray
         * Input: int array and number is need found
         * Output: First index of Number in array
         * **/
        public int Run(int[] array, int number)
        {
            if (array.Length <= 0)
            {

                Lib.Log("Invalid Input. Input array size must be greater than 0 ");
                return -1;

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i]) return i;
            }
            return -1;
        }
    }
}
