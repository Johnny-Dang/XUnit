using ConsoleApp1;
namespace UnitTestDemo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange (prepare data)
            int a = 1;
            int b = 2; 

            //Act
            int result = Add(a, b);

            //Assert
            Assert.Equal(3, result);
        }

        public void Test2()
        {
            //Arrange (prepare data)
            int a = 1;
            int b = 2;

            //Act
            int result = Add(a, b);

            //Assert
            Assert.Equal(3, result);
        }


        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}