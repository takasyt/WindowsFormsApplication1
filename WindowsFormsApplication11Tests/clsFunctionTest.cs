using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WindowsFormsApplication1;

namespace WindowsFormsApplication11Tests
{
    [TestFixture]
    public class clsFunctionTest
    {

        [TestCase("aaa()",TestName = "aaa()")]
        public void ToStringTest(String name)
        {
            clsFunction o = new clsFunction(name);
            Assert.AreEqual("aaa", o.ToString());
        }
    }
}
