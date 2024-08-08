using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx13
    {
        /**
         * reverses the numbers in the array
         * Input: int array
         * Output: Array is reversed
         * **/
        public int[] Run(int[] array)
        {
            if (array.Length <= 0)
            {

                Lib.Log("Invalid Input. Input array size must be greater than 0 ");
                return new int[] { };

            }
            int left = 0, right = array.Length - 1,temp;
            while (left < right)
            {
                temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
            return array;
        }
    }
}
