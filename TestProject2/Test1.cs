using Calculator;

namespace TestProject2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Calc calc = new Calc();

            //Act
            int result = calc.Add(4, 5);

            //Assert
            Assert.AreEqual(90, result, "Test is has wild errors.");
        }
    }
}
