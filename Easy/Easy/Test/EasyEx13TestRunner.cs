using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx13TestRunner : TestRunner
    {
        public EasyEx13TestRunner(string title) : base(title)
        {

        }
        public class EasyEx13TestCase : TestCase
        {
            int[] input;
            int[] expected;

            public EasyEx13TestCase(string title, int[] input, int[] expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {

                int[] result = new EasyEx13().Run(input);
                isPass = IsTwoArrayEqual(result, expected);

            }
        }
        public override void Run()
        {
            // Test exercises 13
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<Object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
            object[] testCaseData02 = { "Case with negative number", new int[] { -2, 5, 1 }, new int[] { 1, 5, -2 } };
            object[] testCaseData03 = { "Empty array case", new int[] { }, new int[] { } };

            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);

            data.ForEach((testCaseData) =>
            {
                EasyEx13TestCase easyEx13TestCase = new EasyEx13TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int[])testCaseData[2]);
                easyEx13TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
