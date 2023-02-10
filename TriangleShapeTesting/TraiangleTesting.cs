using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleShapeTesting
{
    [TestFixture]
   
    public class TriangleTesting
    {
        [Test]
        public void EquilateralTriangleTest1()
        {
            Triangle t1 = new Triangle();
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            string actual = t1.AnalyzeTriangle(21, 21, 21);
            Assert.AreEqual(expected, actual);

        }
     

    }
}


