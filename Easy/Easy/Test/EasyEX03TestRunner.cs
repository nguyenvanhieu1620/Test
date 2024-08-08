using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEX03TestRunner : TestRunner
    {
        public EasyEX03TestRunner(string title) : base(title)
        {

        }
        public class EasyEX03TestCase : TestCase
        {
            int[] input;
            int expected;

            public EasyEX03TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }
            public override void check()
            {
                int result = new EasyEx03().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            /**
            *expected 0 if two input numbers is not in the same class
            * expected 1 if both input numbers is old
            * expected 2 if both input numbers is even
            * expected -1 if element of array 
             **/
            Log(ConcatTitleDisplay(new string[] { "=== START", title }));
            List<object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new int[] { 2, 2 }, 2 };
            object[] testCaseData02 = { "Case with negative number", new int[] { 2, 3, 3 }, -1 };
            object[] testCaseData03 = { "nomal case 02", new int[] { 3, 3 }, 1 };
            object[] testCaseData04 = { "nomal case 03", new int[] { -4, 2 }, 2 };
            object[] testCaseData05 = { "nomal case 04", new int[] { -3, 2 }, 0 };
            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);
            data.Add(testCaseData04);
            data.Add(testCaseData05);
            data.ForEach((testCaseData) =>
            {
                EasyEX03TestCase easyEX03TestCase = new EasyEX03TestCase(ConcatTitleDisplay(new string[] { title, (string)(testCaseData[0]) }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEX03TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
