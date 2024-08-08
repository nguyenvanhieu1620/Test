using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class EasyEx01
    {
        /**
         * Comment...
         * Swap the positions of 3 numbers a,b,c in array
         * **/
        public int[] Run(int[] input)
        {
            if (input.Length != 3)
            {
                Lib.Log("Invalid Input. Input array size must be 3");
                return new int[] { };
            }
            int temp = input[0];
            input[0] = input[1];
            input[1] = input[2];
            input[2] = temp;
            return input;
        }
    }
}
