using exercise4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Theresa's grade book";
            Console.WriteLine(g2.Name);

            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
