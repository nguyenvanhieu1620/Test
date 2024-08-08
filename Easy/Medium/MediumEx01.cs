using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;


namespace com.yotech.exercises
{
    class MediumEx01
    {
        public int[] Run(int[] array, string s)
        {
            if (s == "Tang")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < min) min = j;
                    }
                    Swap(array[i], array[min]);
                }
            }
            else if (s == "Giam")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] > min) min = j;
                    }
                    Swap(array[i], array[min]);
                }
            }
            return array;
        }
    }
}
