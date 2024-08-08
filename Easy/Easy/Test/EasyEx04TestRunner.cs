using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx04TestRunner : TestRunner
    {
        public EasyEx04TestRunner(string title) : base(title)
        {

        }
        public class EasyEx04TestCase : TestCase
        {
            int[] input;
            int expected;

            public EasyEx04TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                int result = new EasyEx04().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "==== Start", title }));
            List<object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new int[] { 1, 4, 7, 8, 12, 16 }, 4 };
            object[] testCaseData02 = { "nomal case 02", new int[] { 1, 3, 7, 9, 11, 17 }, 0 };
            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.ForEach((testCaseData) =>
            {
                EasyEx04TestCase easyEx04TestCase = new EasyEx04TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEx04TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
