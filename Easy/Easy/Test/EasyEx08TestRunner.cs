using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx08TestRunner : TestRunner
    {
        public EasyEx08TestRunner(string title) : base(title)
        {

        }
        public class EasyEx08TestCase : TestCase
        {
            int input;
            bool expected;
            public EasyEx08TestCase(string title, int input, bool expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                bool result = new EasyEx08().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", 7, true };
            object[] testCaseData02 = { "nomal case 02", 4, false };
            data.Add(testCaseData01);
            data.Add(testCaseData02);

            data.ForEach((testCaseData) =>
            {
                EasyEx08TestCase easyEx08TestCase = new EasyEx08TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int)testCaseData[1], Convert.ToBoolean(testCaseData[2]));
                easyEx08TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
