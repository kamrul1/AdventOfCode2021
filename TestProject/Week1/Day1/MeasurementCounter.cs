using System.Collections.Generic;
using System.Linq;

namespace TestProject.Week1.Day1
{
    public class MeasurementCounter
    {
        private readonly int[]? _inputArray;
        private const int ThreeUnitStep = 3;
        
        public MeasurementCounter(int[]? inputArray)
        {
            _inputArray = inputArray;
        }

        public MeasurementCounter():this(null)
        {
        }

        public static bool IsChangeIncrease(int firstValue, int secondValue) 
            => firstValue < secondValue;
        
        public int MaxStartIndexForThreeSum() 
            => (_inputArray != null) ? _inputArray.Length - 2 : 0;

        public int NoOfIncreases() 
            => TotalHelper.NumberOfIncreases(_inputArray!);

        public int NumberOfThreeSumIncreases()
        {
            var threeSumsArray = ThreeMeasuredSumArray();
            return TotalHelper.NumberOfIncreases(threeSumsArray!);
        }


        public int SumOfThreeIndexes(int startIndex = 0) 
            => TotalHelper.SumOfUnitSteps(startIndex, _inputArray!, ThreeUnitStep);


        public int[] ThreeMeasuredSumArray()
        {
            var maxStartIndex = MaxStartIndexForThreeSum();
            return GetSumOfThreeUnits(maxStartIndex);
            
        }

        private int[] GetSumOfThreeUnits(int maxStartIndex)
        {
            return Enumerable.Range(0, maxStartIndex)
                .Select(SumOfThreeIndexes).ToArray();
        }
    }
}