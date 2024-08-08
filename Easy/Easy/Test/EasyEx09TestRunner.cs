using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx09TestRunner : TestRunner
    {
        public EasyEx09TestRunner(string title) : base(title)
        {

        }
        public class EasyEx09TestCase : TestCase
        {
            int[] input;
            int expected;
            public EasyEx09TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                int result = new EasyEx09().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<Object[]> data = new List<object[]>();
            Object[] testCaseData01 = { "nomal case 01", new int[] { 5, 2 }, 1 };
            Object[] testCaseData02 = { "nomal case 02", new int[] { 5, 0 }, 0 };
            data.Add(testCaseData01);
            data.Add(testCaseData02);

            data.ForEach((testCaseData) =>
            {
                EasyEx09TestCase easyEx09TestCase = new EasyEx09TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEx09TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
