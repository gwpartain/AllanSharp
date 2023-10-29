using System;
using System.Collections;
using System.Collections.Generic;

namespace AllanSharp
{
    public class AllanCalcService
    {
        public void ModifiedAllanDeviation(IList<double> observations, double measurementInterval)
        {
            //use the count of observations and the interval to determine the sweep range in time to determine the start and stop periods
            var startSeconds = 0;
            var endSeconds = observations.Count * measurementInterval;


        }


        /*
         * Need an overlapping and a non-overlapping calculation of the allen variance. The allen deviation is the square root of either of those calculations
         */
    }
}
