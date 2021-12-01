using System.Linq;

namespace TestProject.Week1.Day1
{
    public class MeasurementCounter
    {
        private readonly int[] _inputArray;
        
        public MeasurementCounter(int[] inputArray)
        {
            _inputArray = inputArray;
        }

        public MeasurementCounter()
        {
        }

        public static bool IsChangeIncrease(int firstValue, int secondValue)
        {
            return firstValue < secondValue;
        }

        public int NoOfIncreases()
        {

            var increaseCounter = 0;

            for (int previous = 0, next = 1 ; next < _inputArray.Length; previous++, next++)
            {
                if (IsChangeIncrease(_inputArray[previous], _inputArray[next]))
                {
                    increaseCounter++;
                }
            }

            return increaseCounter;

        }
    }
}