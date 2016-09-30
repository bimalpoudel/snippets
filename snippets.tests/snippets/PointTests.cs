using Microsoft.VisualStudio.TestTools.UnitTesting;
using snippets.snippets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snippets.snippets.Tests
{
    [TestClass()]
    public class PointTests: BaseTest
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Point p = new Point(0, 0);
            Assert.AreEqual("[0,0]", p.ToString());
        }
    }
}