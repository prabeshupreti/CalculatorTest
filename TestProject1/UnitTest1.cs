using Calculator;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            Calc calc = new Calc();

            //Act
            int result = calc.Add(5, 4);

            //Assert
            Assert.(result, 9);
        }
    }
}
