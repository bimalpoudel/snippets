using snippets.snippets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snippets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Program p = new Program();

            p.testVersion();
            p.testPoint();
            p.testCube();
            p.testNumbers();
            p.testKeygen();
            p.testJSON();
            p.testSHA1FromString();
            p.testMD5FromString();
            p.testIndexers();
            p.testDelegator();
            p.testUnsafe();

            Console.ReadLine();
        }

        private void testVersion()
        {
            /**
             * @see http://stackoverflow.com/questions/19532942/which-version-of-c-sharp-am-i-using
             * @see https://github.com/dotnet/roslyn
             *
             * cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
             * csc /?
             * Microsoft(R) Visual C# Compiler version 4.6.1586.0
             * for C# 5
             */
            Console.WriteLine("C# Version: " + typeof(string).Assembly.ImageRuntimeVersion);
            // v4.0.30319

            /**
             * @see http://stackoverflow.com/questions/247621/what-are-the-correct-version-numbers-for-c/247623#247623
             * C# 1.0 released with .NET 1.0
             * C# 1.2 (bizarrely enough); released with .NET 1.1
             * C# 2.0 released with .NET 2.0
             * C# 3.0 released with .NET 3.5
             * C# 4.0 released with .NET 4
             * C# 5.0 released with .NET 4.5
             * C# 6.0 released with .NET 4.6
             */
        }

        private void testPoint()
        {
            Point p = new Point(0, 0);
            Console.WriteLine("Point: " + p);
        }

        private void testCube()
        {
            Cube c = new Cube(0, 0, 0);
            Console.WriteLine("Cube: " + c);
        }

        private void testNumbers()
        {
            numbers n = new numbers();
            Console.WriteLine("Numbers: " + n.GenerateString(5));
        }

        private void testKeygen()
        {
            keygen k = new keygen();
            string key = k.generate(5);
            Console.WriteLine("Key: " + key);
        }

        /**
         * @todo Fix the output to proper JSON
         */
        private void testJSON()
        {
            Dictionary<string, Dictionary<string, string>> body = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> measures = new Dictionary<string, string>();
            Dictionary<string, string> colors = new Dictionary<string, string>();

            measures.Add("height", "160");
            measures.Add("weight", "65.4");
            body.Add("body", measures);

            colors.Add("eyes", "blue");
            colors.Add("hair", "brown");
            body.Add("colors", colors);

            // @see https://msdn.microsoft.com/en-us/library/system.web.script.serialization.javascriptserializer(v=vs.110).aspx
            // var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            // var bodyJSON = serializer.Serialize(body);
            // var deserializedResult = serializer.Deserialize<List<Person>>(bodyJSON);

            Console.WriteLine("JSON: " + body);
        }

        /**
         * @see https://msdn.microsoft.com/en-us/library/system.security.cryptography.hashalgorithm.computehash.aspx
         */
        private void testSHA1FromString()
        {
            hasher hasher = new snippets.hasher();
            string hash = hasher.sha1("");
            Console.WriteLine("SHA1 Hash: " + hash);
        }

        private void testMD5FromString()
        {
            hasher hasher = new snippets.hasher();
            string hash = hasher.md5("");
            Console.WriteLine("MD5 Hash: " + hash);
        }

        private void testIndexers()
        {
            Indexers names = new Indexers(5);
            names[0] = "One";
            names[1] = "Two";
            names[2] = "Three";
            // names[3] = "Four"; // filled default
            // names[4] = "Five"; // filled default
            // names[5] = "Six"; // cut off
            // names[6] = "Seven"; // cut off
            for (int i = 0; i < Indexers.size; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        private void testDelegator()
        {
            delegator d = new delegator();

            //create delegate instances using anonymous method
            NumberChanger nc0 = delegate (int x)
            {
                Console.WriteLine("Delegator: Anonymous Method: {0}", x);
            };

            //calling the delegate using the anonymous method
            nc0(10);

            //instantiating the delegate using the named methods
            //nc = new NumberChanger(AddNum);
            NumberChanger nc1 = new NumberChanger(d.AddNum);

            //calling the delegate using the named methods
            nc1(5);

            //instantiating the delegate using another named methods
            //nc = new NumberChanger(MultNum);
            NumberChanger nc2 = new NumberChanger(d.MultNum);

            //calling the delegate using the named methods
            nc2(2);
        }

        // project > properties > build > allow unsafe code
        private unsafe void testUnsafe()
        {
            int var = 20;
            int* p = &var;
            Console.WriteLine("Unsafe: Data is: {0} ", var);
            Console.WriteLine("Unsafe: Address is: {0}", (int)p);
        }
    }
}