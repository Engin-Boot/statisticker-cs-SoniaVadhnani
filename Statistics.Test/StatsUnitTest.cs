using System;
using System.Collections.Generic;
using Xunit;
using Statistics;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{1.5F, 8.9F, 3.2F, 4.5F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 4.525F) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 8.9F) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.5F) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float>{});
            
            Assert.True(computedStats.Average  == float.NaN);
            Assert.True(computedStats.Max  == float.NaN);
            Assert.True(computedStats.Min  == float.NaN);

        }
    }  
}
//All fields of computedStats (average, max, min) must be
//Double.NaN (not-a-number), as described in
//https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
