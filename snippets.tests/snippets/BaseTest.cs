using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @see http://stackoverflow.com/questions/4786884/how-to-write-output-from-a-unit-test
 */
namespace snippets.snippets.Tests
{
    [TestClass]
    public abstract class BaseTest
    {
        public TestContext TestContext { get; set; }

        public string Class
        {
            get { return this.TestContext.FullyQualifiedTestClassName; }
        }

        public string Method
        {
            get { return this.TestContext.TestName; }
        }

        protected virtual void show(string message)
        {
            Output.Testing.Trace.WriteLine(message); // outputs: with bitoxygen testing pane
            // Console.WriteLine(message); // no output
            // Debug.WriteLine(message); // no output
            // System.Diagnostics.Trace.WriteLine(message); // no output
            // TestContext.WriteLine(message); // no output
            // Trace.WriteLine(message); // no output
        }

        ~BaseTest()
        {
            show(string.Format("Just ran: {0}.{1}()", Class, Method));
        }
    }
}