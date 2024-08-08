using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEX02TestRunner : TestRunner
    {
        public EasyEX02TestRunner(string title) : base(title)
        {

        }
        public class EasyEX02TestCase : TestCase
        {
            double[] input;
            double expected;
            public EasyEX02TestCase(string title, double[] input, double expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }
            public override void check()
            {
                double result = new EasyEx02().Run(input);
                isPass = result == expected;
            }
        }
        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "=== Start", title }));
            // 01: Prepring Testcase data 
            List<object[]> data = new List<object[]>();
            object[] testCaseData01 = { "Normal case 01", new double[] { 2, 10 }, 1024 };
            object[] testCaseData02 = { "Case with negative number", new double[] { 1, 2, 3 }, 0 };
            object[] testCaseData03 = { "Case with negative number", new double[] { 2, -3 }, 0.125 };
            object[] testCaseData04 = { "Case with negative number", new double[] { -2, 3 }, -8 };
            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);
            data.Add(testCaseData04);
            // 02: Construct testcase object and run the test
            data.ForEach((testCaseData) =>
            {
                EasyEX02TestCase easyEX02TestCase02 = new EasyEX02TestCase(ConcatTitleDisplay(new string[] { title, (string)(testCaseData[0]) }), (double[])testCaseData[1], Convert.ToDouble(testCaseData[2]));
                easyEX02TestCase02.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
