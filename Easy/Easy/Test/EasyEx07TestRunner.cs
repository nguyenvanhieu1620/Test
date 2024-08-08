using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx07TestRunner : TestRunner
    {
        public EasyEx07TestRunner(string title) : base(title) { }
        public class EasyEx07TestCase : TestCase
        {
            int[] input;
            int expected;
            public EasyEx07TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {

                int result = new EasyEx07().Run(input);

                isPass = result == expected;
            }
        }
        public override void Run()
        {

            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<Object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new int[] { 1, 4, 7, 8, 12, 16 }, 8 };
            object[] testCaseData02 = { "nomal case 02", new int[] { 2, 4, 8, 12, 18 }, 0 };
            data.Add(testCaseData01);
            data.Add(testCaseData02);

            data.ForEach((testCaseData) =>
            {
                EasyEx07TestCase easyEx07TestCase = new EasyEx07TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEx07TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
