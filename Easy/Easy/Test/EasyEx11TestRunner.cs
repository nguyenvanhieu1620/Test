using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;
namespace com.yotech.exercises
{
    class EasyEx11TestRunner : TestRunner
    {
        public EasyEx11TestRunner(string title) : base(title)
        {

        }
        public class EasyEx11TestCase : TestCase
        {
            int[] input;
            int expected;
            public EasyEx11TestCase(string title, int[] input, int expected) : base(title)
            {
                this.input = input;
                this.expected = expected;
            }

            public override void check()
            {
                int result = new EasyEx11().Run(input);
                isPass = result == expected;

            }
        }
        public override void Run()
        {
            Log(ConcatTitleDisplay(new string[] { "==== START", title }));
            List<Object[]> data = new List<object[]>();
            object[] testCaseData01 = { "nomal case 01", new int[] { 5, 2, 16, 3 }, 2 };
            object[] testCaseData02 = { "nomal case 01", new int[] { 5, 0, 7, 20, 25 }, 0 };
            object[] testCaseData03 = { "nomal case 01", new int[] { }, -1 };

            data.Add(testCaseData01);
            data.Add(testCaseData02);
            data.Add(testCaseData03);

            data.ForEach((testCaseData) =>
            {
                EasyEx11TestCase easyEx11TestCase = new EasyEx11TestCase(ConcatTitleDisplay(new string[] { title, (string)testCaseData[0] }), (int[])testCaseData[1], (int)testCaseData[2]);
                easyEx11TestCase.validate();
            });
            Log(ConcatTitleDisplay(new string[] { "==== END", title }));
        }
    }
}
