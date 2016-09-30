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
    public class numbersTests
    {
        [TestMethod()]
        public void GenerateStringTest()
        {
            int total = 5;

            numbers n = new numbers();
            string numbers =  n.GenerateString(total);
            Assert.AreEqual(numbers.Length, total);
        }
    }
}