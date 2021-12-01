
using System.Threading.Tasks;
using Xunit;

namespace TestProject.Week1.Day1
{
    public class MeasurementCounterShould
    {

        [Theory]
        [InlineData(10,20,true)]
        [InlineData(10,9, false)]
        public void ReturnIncreases(int firstValue, int secondValue, bool expected)
        {
            var sut = new MeasurementCounter();

            var result = MeasurementCounter.IsChangeIncrease(firstValue, secondValue);
            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnSevnIncreases()
        {
            var input = new int[] {199, 200, 208, 210, 200, 207, 240, 269, 260, 263};

            var sut = new MeasurementCounter(input);

            var result = sut.NoOfIncreases();
            
            Assert.Equal(7, result);
        }

        [Fact]
        public async Task ReturnsMeasurementIncreases()
        {
            var input = await Reader.LoadAsync("MeasurementFile.txt");

            var sut = new MeasurementCounter(input);

            var result = sut.NoOfIncreases();
            
            Assert.Equal(1154, result);
        }
    }
}