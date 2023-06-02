using System;
using TechTalk.SpecFlow.Tracing;

namespace ClassLibrary1.SpecflowPlugin
{
    public class MyTraceListener : ITraceListener
    {
        public void WriteTestOutput(string message)
        {
            Console.WriteLine("foo");
        }

        public void WriteToolOutput(string message)
        {
            Console.WriteLine("-> " + "foo");
        }
    }
}
