using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var adder = new SimpleAdder();

            // Act
            var result = adder.Add(3, 4);

            // Assert
            Assert.Equal(7, result);
        }
    }
}
