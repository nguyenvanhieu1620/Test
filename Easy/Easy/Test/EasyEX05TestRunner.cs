using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEX05TestRunner : TestRunner
    {
        public EasyEX05TestRunner(string title) : base(title)
        {

        }
        public class EasyEX05TestCase : TestCase
        {
            int[] input;
            int expected;

            public EasyEX05TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {

                int result = new EasyEx05().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {

            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<object[]> data = new List<object[]>();
            Object[] testCaseData01 = { "nomal case 01", new int[] { 1, 4, 7, 8, 12, 16 }, 2 };
            Object[] testCaseData02 = { "nomal case 02", new int[] { 2, 4, 8, 12, 18 }, 0 };
            data.Add(testCaseData01);
            data.Add(testCaseData02);

            data.ForEach((testCaseData) =>
            {
                EasyEX05TestCase easyEX05TestCase = new EasyEX05TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEX05TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
