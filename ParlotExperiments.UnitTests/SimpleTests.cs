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

            var parser = Separated<char, TextSpan>(Terms.Char(','), Terms.String());
            
            var result = parser.Parse("a, b, c");

            var result2 = Terms.Pattern(c=> true).Parse("a, b, c");

            Assert.Pass();

        }

        [Test]
        public void Before()
        {
            var str = "Save()";

            var result = AnyCharBefore<char>(Terms.Char('(')).Parse(str);

            Assert.Pass();
        }
    }
}
