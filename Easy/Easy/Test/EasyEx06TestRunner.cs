using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx06TestRunner : TestRunner
    {
        public EasyEx06TestRunner(string title) : base(title)
        {

        }
        public class EasyEx06TestCase : TestCase
        {
            int[] input;
            int expected;
            public EasyEx06TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                int result = new EasyEx06().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {

            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new int[] { 1, 4, 7, 8, 12, 16 }, 40 };
            object[] testCaseData02 = { "nomal case 02", new int[] { 2, 4, 8, 12, 18 }, 44 };
            data.Add(testCaseData01);
            data.Add(testCaseData02);

            data.ForEach((testCaseData) =>
            {
                EasyEx06TestCase easyEx06TestCase = new EasyEx06TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEx06TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
