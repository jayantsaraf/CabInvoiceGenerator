using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGen
{
    public class InvoiceSummary
    {
        public int mNoOfRides = 0;
        public double mTotalFare = 0;
        public double mAverageFarePerRide = 0;

        public InvoiceSummary(int noOfRides, double totalFare)
        {
            this.mNoOfRides = noOfRides;
            this.mTotalFare = totalFare;
            this.mAverageFarePerRide = mTotalFare / mNoOfRides;
        }
    }
}
