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
    public class keygenTests
    {
        [TestMethod()]
        public void generateTest()
        {
            int total = 5;

            keygen k = new keygen();
            string keygen = k.generate(total);
            Assert.AreEqual(keygen.Length, total);
        }

        [TestMethod()]
        public void generateLoopTest()
        {
            for (int total = 1; total <= 500; ++total)
            {
                keygen k = new keygen();
                string keygen = k.generate(total);
                Assert.AreEqual(keygen.Length, total);
            }
        }
    }
}