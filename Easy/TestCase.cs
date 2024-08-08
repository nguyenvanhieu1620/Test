using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;

namespace com.yotech.exercises
{
    abstract class TestCase
    {
        protected string title;
        protected bool isPass;

        public TestCase(string title)
        {
            this.title = title;
        }

        public abstract void check();

        public void validate()
        {
            check();
            log();
        }

        public void log()
        {
            if (isPass)
            {
                LogCorrect(title + " - Pass");
            } else
            {
                LogIncorrect(title + " - Fail");
            }
        }
    }
}
