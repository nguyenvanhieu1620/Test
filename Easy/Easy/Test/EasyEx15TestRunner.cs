using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;

namespace com.yotech.exercises
{
    class EasyEx15TestRunner : TestRunner
    {
        public EasyEx15TestRunner(string title) : base(title)
        {

        }
        public class EasyEx15TestCase : TestCase
        {
            int input;
            int expected;

            public EasyEx15TestCase(string title, int input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                int result = new EasyEx15().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            // Test exercises 15
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<Object[]> data = new List<object[]>();
            object[] testCaseData01 = { "Normal case 01", 5, 120 };
            object[] testCaseData02 = { "Case with negative number", -5, -1 };
            object[] testCaseData03 = { "Number equal 0 or 1", 1, 1 };

            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);

            data.ForEach((testCaseData) =>
            {
                EasyEx15TestCase easyEx15TestCase = new EasyEx15TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int)testCaseData[1], (int)testCaseData[2]);
                easyEx15TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
