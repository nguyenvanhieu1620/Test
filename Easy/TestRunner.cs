namespace com.yotech.exercises
{
    abstract class TestRunner
    {
        protected string title;

        public TestRunner(string title)
        {
            this.title = title;
        }

        public abstract void Run();
    }
}
