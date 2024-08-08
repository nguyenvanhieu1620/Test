using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yotech.exercises
{
    class Lib
    {
        public static bool isDebugging = true;

        public static bool IsTwoArrayEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Log(string message = "", bool isNewLine = true, ConsoleColor textColor = ConsoleColor.White)
        {
            if (!isDebugging)
            {
                return;
            }
            Console.ForegroundColor = textColor;
            if (isNewLine)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
            Console.ResetColor();
        }

        public static void LogCorrect(string message = "", bool isNewLine = true)
        {
            Log(message, isNewLine, ConsoleColor.Green);
        }

        public static void LogIncorrect(string message = "", bool isNewLine = true)
        {
            Log(message, isNewLine, ConsoleColor.Red);
        }

        public static string ConcatTitleDisplay(string [] messageParts, string connector = "-")
        {
            if (messageParts.Length == 0) return "";
            if (messageParts.Length == 1) return messageParts[0];
            string result = "";
            for(int i = 0; i<messageParts.Length - 1; i++)
            {
                result += messageParts[i] + " " + connector + " ";
            }
            result += messageParts[messageParts.Length - 1];
            return result;
        }

        public static void Swap(int Number1, int Number2)
        {
            int temp;
            temp = Number1;
            Number1 = Number2;
            Number2 = temp;
        }

    }    
}

