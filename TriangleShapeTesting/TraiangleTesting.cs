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
        [Test]
        public void IsoscelesTriangleTest2()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            String actual = t1.AnalyzeTriangle(21, 7, 21);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsoscelesTriangleTest3()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            String actual = t1.AnalyzeTriangle(13, 13, 9);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void IsoscelesTriangleTest4()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            String actual = t1.AnalyzeTriangle(13, 9, 9);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ScaleneTriangleTest5()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(9, 13, 15);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ScaleneTriangleTest6()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(21, 22, 23);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest7()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest8()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(7, 13, 9);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest9()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(18, 19, 20);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ZeroLentghTest10()
        {
            Triangle t1 = new Triangle();
            String expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = t1.AnalyzeTriangle(0, 0, 0);
            Assert.AreEqual(expected, actual);
        }




    }
}


