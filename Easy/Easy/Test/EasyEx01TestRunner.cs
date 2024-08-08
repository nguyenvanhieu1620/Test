using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;

namespace com.yotech.exercises
{
    class EasyEx01TestRunner : TestRunner
    {
        public EasyEx01TestRunner(string title) : base(title)
        {
        }

        public class EasyEx01TestCase : TestCase
        {
            int[] input;
            int[] expected;

            public EasyEx01TestCase(string title, int[] input, int[] expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                int[] result = new EasyEx01().Run(input);
                isPass = IsTwoArrayEqual(result, expected);
            }
        }

        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));

            // 01: Preparing testcase data
            List<object[]> data = new List<object[]>();
            object[] testCaseData01 = new object[] { "Normal case 01", new int[] { 1, 2, 3 }, new int[] { 2, 1, 3 } };
            object[] testCaseData02 = new object[] { "Case with negative number", new int[] { -2, 5, 1 }, new int[] { 5, 1, -2 } };
            data.Add(testCaseData01);
            data.Add(testCaseData02);

            // 02: Construct testcase object and run the test
            data.ForEach((testCaseData) =>
            {
                EasyEx01TestCase easyEx01TestCase = new EasyEx01TestCase(ConcatTitleDisplay(new string[] { title, (string)(testCaseData[0]) }), (int[])testCaseData[1], (int[])testCaseData[2]);
                easyEx01TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
