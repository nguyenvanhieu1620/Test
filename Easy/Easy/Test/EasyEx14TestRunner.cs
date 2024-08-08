using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx14TestRunner : TestRunner
    {
        public EasyEx14TestRunner(string title) : base(title)
        {

        }
        public class EasyEx14TestCase : TestCase
        {
            int[] input;
            int number;
            int expected;

            public EasyEx14TestCase(string title, int[] input, int number, int expected) : base(title)
            {
                this.input = input;
                this.number = number;
                this.expected = expected;
            }

            public override void check()
            {
                int result = new EasyEx14().Run(input, number);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            // Test exercises 14
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<Object[]> data = new List<object[]>();
            object[] testCaseData01 = { "Normal case 01", new int[] { 1, 2, 3 }, 2, 1 };
            object[] testCaseData02 = { "Case with negative number", new int[] { -2, 5, 1 }, 1, 2 };
            object[] testCaseData03 = { "Empty array case", new int[] { }, 5, -1 };
            object[] testCaseData04 = { "Case doenn't not appear in array", new int[] { 1, 3, 4, 6 }, 5, -1 };

            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);
            data.Add(testCaseData04);

            data.ForEach((testCaseData) =>
            {
                EasyEx14TestCase easyEx14TestCase = new EasyEx14TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2], (int)testCaseData[3]);
                easyEx14TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
