using ITI;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           bool result= logger.log("logs.txt", $"Date : {DateTime.Now},this is date now");
            //test if it true
            Assert.IsTrue( result );
        }
    }
}