
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit;

namespace TestProject.Week1.Day1
{
    public class MeasurementCounterShould
    {
        
        private readonly int[] _smallInputSample = {199, 200, 208, 210, 200, 207, 240, 269, 260, 263};
        private MeasurementCounter GetMeasurementCounterWithSmallSampleData() 
            => new MeasurementCounter(_smallInputSample);
        private static async Task<MeasurementCounter> GetMeasurementCounterWithFileData()
        {
            var input = await Reader.LoadAsync("MeasurementFile.txt");
            return new MeasurementCounter(input);
        }
        
        

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
        public void ReturnNumberOfIncreasesInArray()
        {

            var sut = GetMeasurementCounterWithSmallSampleData();

            var result = sut.NoOfIncreases();
            
            Assert.Equal(7, result);
        }

       

        [Fact]
        public async Task ReturnsNumberOfIncreasesInFileData()
        {
            var sut = await GetMeasurementCounterWithFileData();

            var result = sut.NoOfIncreases();
            
            Assert.Equal(1154, result);
        }

        [Fact]
        public void ReturnSumOfFirstThree()
        {

            var sut = GetMeasurementCounterWithSmallSampleData();

            var result = sut.SumOfThreeIndexes();
            
            Assert.Equal(607, result);
        }
        
        [Fact]
        public void ReturnSumOfNextThree()
        {

            var sut = GetMeasurementCounterWithSmallSampleData();

            var result = sut.SumOfThreeIndexes(1);
            
            Assert.Equal(618, result);
        }

        [Fact]
        public void ReturnMaxStartIndex()
        {

            var sut = GetMeasurementCounterWithSmallSampleData();

            var result = sut.MaxStartIndexForThreeSum();
            
            Assert.Equal(8, result);
        }

        [Fact]
        public void ReturnThreeMeasuredSumArray()
        {

            var sut = GetMeasurementCounterWithSmallSampleData();

            var result = sut.ThreeMeasuredSumArray();

            Assert.Contains(792, result!);       
        }

        [Fact]
        public void ReturnNoFiveSumIncreases()
        {

            var sut = GetMeasurementCounterWithSmallSampleData();

            var result = sut.NumberOfThreeSumIncreases();
            
            Assert.Equal(5, result);
        }

        [Fact]
        public async Task ReturnActualSumIncreases()
        {
            var sut = await GetMeasurementCounterWithFileData();

            var result = sut.NumberOfThreeSumIncreases();
            
            Assert.Equal(1127, result);
        }


    }
}