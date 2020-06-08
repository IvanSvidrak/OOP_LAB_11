using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int b = 10;
            double c = 3.14;
            double result = OOP_LAB_1_19.Program.Sb(a, b, c);
            Assert.AreEqual(188, 4, result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 3;
            int b = 10;
            double c = 3.14;
            double result = OOP_LAB_1_19.Program.V(a, b, c);
            Assert.AreEqual(282, 6, result);

        }
    }
}
