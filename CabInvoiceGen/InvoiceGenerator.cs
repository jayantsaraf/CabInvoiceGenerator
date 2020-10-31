using CabInvoiceGenerator;
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
        /// 

       
        public double CalculateFare(double distance, int time)
        {
            int minimumFare = 5;
            int farePerKM = 10;
            int farePerMinute = 1;
            double totalFare = minimumFare + farePerKM * distance + farePerMinute* time;
            return totalFare;
        }
        /// <summary>
        /// Calculate total fare of multiple rides
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double CalculateMultipleFare(double[] distance, int[] time)
        {
            int minimumFare = 5;
            int farePerKM = 10;
            int farePerMinute = 1;
            double totalOfMultipleRides = 0;
            for (int i= 0;i < distance.Length; i++)
            {
                double totalFare = minimumFare + farePerKM * distance[i] + farePerMinute * time[i];
                totalOfMultipleRides += totalFare;
            }
            
            return totalOfMultipleRides;
        }
        /// <summary>
        /// Calculate average fare of multiple rides
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public InvoiceSummary EnhancedInvoice(Ride[] rides)
        {
            int minimumFare = 5;
            int farePerKM = 10;
            int farePerMinute = 1;
            double totalOfMultipleRides = 0;
            foreach(Ride ride in rides)
            {
                double totalFare = minimumFare + farePerKM * ride.distance + farePerMinute * ride.time;
                totalOfMultipleRides += totalFare;
            }
            
            return new InvoiceSummary(rides.Length, totalOfMultipleRides);
        }

        
    }
}
