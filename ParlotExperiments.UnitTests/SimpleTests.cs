using NUnit.Framework;
using Parlot;
using Parlot.Fluent;
using static Parlot.Fluent.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParlotExperiments.UnitTests
{
    [TestFixture]
    public class SimpleTests
    {
        [Test]
        public void Test1()
        {
            var str = "Save().Close()";

            var closeParentasis = Terms.Char(')');
            var dot = Terms.Char('.');

            var result = closeParentasis.Parse(str);

            Assert.Pass();

        }

        [Test]
        public void Test2()
        {
            //var str = "Save().Close()";

            //// var parser = Terms.Text(")").And(Terms.Text("."));

            //// var parser =  Parsers.Separated<string, string>(").", );
            //var parser = Separated(Terms.Text(")."),  Terms.Text(""));


            //var result = parser.Parse(str);

            var parser = Separated(Terms.Text(","), Terms.NonWhiteSpace(false));
            var result = parser.Parse("1, 2, 3");

            Assert.Pass();

        }
    }
}
