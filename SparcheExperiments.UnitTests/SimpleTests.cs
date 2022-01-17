using NUnit.Framework;
using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparcheExperiments.UnitTests
{
    [TestFixture]
    public class SimpleTests
    {

        [Test]
        public void SplitByDot()
        {
            var str = "Save().Close()";

            var parser = Parse.Letter.Many().Text();

            var result = parser.TryParse(str);

            Console.WriteLine(result);

            Assert.Pass();
        }

    }
}
