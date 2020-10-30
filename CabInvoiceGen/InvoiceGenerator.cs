using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGen
{
    public class InvoiceGenerator
    {
        /// <summary>
        /// Function to calculate fare
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double CalculateFare(double distance, int time)
        {
            int minimumFare = 5;
            int farePerKM = 10;
            int farePerMinute = 1;
            double totalFare = minimumFare + farePerKM * distance + farePerMinute* time;
            return totalFare;
        }
    }
}
