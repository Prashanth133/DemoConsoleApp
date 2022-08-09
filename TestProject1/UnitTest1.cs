using DemoConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public static string helperObj = string.Empty;

        [ClassInitialize]
        public static void ClassInitialize(TestContext _)
        {
            helperObj = "initialiazed";
        }

        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.getNumber();
            Assert.IsTrue(result > 3);
            Assert.IsTrue(result > 4);
            Assert.IsTrue(result > 5);

        }
    }
}
