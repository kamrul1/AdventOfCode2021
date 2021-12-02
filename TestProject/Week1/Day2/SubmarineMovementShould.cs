using System.Collections.Generic;
using Xunit;

namespace TestProject.Week1.Day2
{
    public class SubmarineMovementShould
    {
        private readonly string[] _smallInputSample =
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        };

        [Fact]
        public void CountNumberOfForwardMovement()
        {
            var sut = new SubmarineMovement(_smallInputSample);

            var result = sut.NumberOfForwards();
            
            Assert.Equal(3, result);

        }

        [Fact]
        public void ReturnTotalForwardMovements()
        {
            var sut = new SubmarineMovement(_smallInputSample);

            var result = sut.FinalHorizontalPosition();
            
            Assert.Equal(15, result);
        }

        [Fact]
        public void ReturnMovedDepth()
        {
            var sut = new SubmarineMovement(_smallInputSample);

            var result = sut.MovedDepth();
            
            Assert.Equal(10, result);
        }

        [Fact]
        public void ReturnMultipliedMoves()
        {
            var sut = new SubmarineMovement(_smallInputSample);

            var result = sut.MultipledMoves();
            
            Assert.Equal(150, result);
        }
    
        [Fact]
        public async void ReturnActualFileMultipliedMoves()
        {
            var moves = 
                await MovementLoader.LoadAsync("SubmarineMovementFile.txt");
            
            var sut = new SubmarineMovement(moves);

            var result = sut.MultipledMoves();
            
            Assert.Equal(0, result);
        }
        
    }
}