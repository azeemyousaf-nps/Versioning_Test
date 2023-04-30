namespace TestNuget.Test
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestAdd()
        {
            var answer = TestNuget.Calculation.Calculator.Add(1, 1);
            Assert.AreEqual(2, answer); 
            answer = TestNuget.Calculation.Calculator.Add(2, 1);
            Assert.AreEqual(3, answer);
        }
    }
}