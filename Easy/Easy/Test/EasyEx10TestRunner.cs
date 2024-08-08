using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx10TestRunner : TestRunner
    {
        public EasyEx10TestRunner(string title) : base(title)
        {

        }
        public class EasyEx10TestCase : TestCase
        {
            int[] input;
            int expected;
            public EasyEx10TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                int result = new EasyEx10().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<Object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new int[] { 5, 2, 16, 3 }, 16 };
            object[] testCaseData02 = { "nomal case 01", new int[] { 5, 0, 7, 20, 25 }, 25 };
            object[] testCaseData03 = { "nomal case 01", new int[] { }, -1 };

            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);

            data.ForEach((testCaseData) =>
            {
                EasyEx10TestCase easyEx10TestCase = new EasyEx10TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEx10TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
