using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx03
    {
        /**
         * 
         * return 0 if two input numbers is not in the same class
         * return 1 if both input numbers is old
         * return 2 if both input numbers is even
         * **/
        public int Run(int[] array)
        {
            if (array.Length != 2)
            {
                Lib.Log("Invalid Input. Input array size must be 2");
                return -1;
            }
            if ((array[0] + array[1]) % 2 != 0) return 0;
            return array[0] % 2 == 0 ? 2 : 1;
        }
    }
}
