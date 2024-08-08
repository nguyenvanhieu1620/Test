using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx12TestRunner : TestRunner
    {
        public EasyEx12TestRunner(string title) : base(title)
        {

        }
        public class EasyEx12TestCase : TestCase
        {
            double[] input;
            double expected;

            public EasyEx12TestCase(string title, double[] input, double expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                double result = new EasyEx12().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            Log("====== 12: Preparing Test Case...");
            List<Object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new double[] { 5, 2, 16, 3 }, 6.5 };
            object[] testCaseData02 = { "nomal case 01", new double[] { 5, 0, 7, 20, 25 }, 11.4 };
            object[] testCaseData03 = { "nomal case 01", new double[] { }, -1 };

            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);

            data.ForEach((testCaseData) =>
            {
                EasyEx12TestCase easyEx12TestCase = new EasyEx12TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (double[])testCaseData[1], Convert.ToDouble(testCaseData[2]));
                easyEx12TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
