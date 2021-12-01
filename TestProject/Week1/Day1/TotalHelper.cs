namespace TestProject.Week1.Day1
{
    public static class TotalHelper
    {


        public static int NumberOfIncreases(int[] values)
        {
            var increaseCounter = 0;

            for (int previous = 0, next = 1 ; next < values.Length; previous++, next++)
            {
                if (MeasurementCounter.IsChangeIncrease(values[previous], values[next]))
                {
                    increaseCounter++;
                }
            }

            return increaseCounter;
        }

        public static int SumOfUnitSteps(int startIndex, int[] values, int unitSteps)
        {
            var readUptoIndex = startIndex + unitSteps;
            if (readUptoIndex>values.Length)
            {
                readUptoIndex = values.Length;
            }
            
            var rollingTotal = 0;

            for (var i = startIndex; i < readUptoIndex; i++)
            {
                rollingTotal += values[i];
            }

            return rollingTotal;
        }
    }
}