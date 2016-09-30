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
    public class hasherTests: BaseTest
    {
        [TestMethod()]
        [TestCategory("Hashing: SHA1")]
        public void sha1Test()
        {
            string buffer = "";
            string expected_sha1 = "DA39A3EE5E6B4B0D3255BFEF95601890AFD80709";

            hasher hasher = new snippets.hasher();
            string hash_sha1 = hasher.sha1(buffer);

            Assert.AreEqual(hash_sha1, expected_sha1);
        }

        [TestMethod()]
        [TestCategory("Hashing: SHA1")]
        public void sha12Test()
        {
            string buffer = "SHA1";
            string expected_sha1 = "E1744A525099D9A53C0460EF9CB7AB0E4C4FC939";

            hasher hasher = new snippets.hasher();
            string hash_sha1 = hasher.sha1(buffer);

            Assert.AreEqual(hash_sha1, expected_sha1);
        }

        [TestMethod()]
        [TestCategory("Hashing: MD5")]
        public void md5Test()
        {
            string buffer = "";
            string expected_md5 = "D41D8CD98F00B204E9800998ECF8427E";

            hasher hasher = new snippets.hasher();
            string hash_md5 = hasher.md5(buffer);

            Assert.AreEqual(hash_md5, expected_md5);
        }

        [TestMethod()]
        [TestCategory("Hashing: MD5")]
        public void md52Test()
        {
            string buffer = "MD5";
            string expected_md5 = "7F138A09169B250E9DCB378140907378";

            hasher hasher = new snippets.hasher();
            string hash_md5 = hasher.md5(buffer);

            Assert.AreEqual(hash_md5, expected_md5);
        }
    }
}