using NUnit.Framework;
using CabInvoiceGen;
using CabInvoiceGenerator;
using System.Collections.Generic;

namespace CabInvoiceGenTest
{
    public class Tests
    {
        
        /// <summary>
        /// Test case to check if the function Calculate Fare returns the expected fare 
        /// </summary>
        [Test]
        public void CalculateFareReturnTheFare()
        {
            //// Generating object of class
            InvoiceGenerator invoice = new InvoiceGenerator();

            //// Calculating fare by passing the values of distance = 10 KM and 
            ///minutes = 60 minutes
            double actual = invoice.CalculateFare(10, 60);
            double expected = 165;

            ////Checking if the test case passes
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test case to return aggregate fare of given mutiple rides
        /// </summary>
        [Test]
        public void CalculateFareReturnsTotalFareOfMultipleRides()
        {
            //// Generating object of class
            InvoiceGenerator invoice = new InvoiceGenerator();

            //// Calculating fare by passing the values of distance = 10 KM and 
            ///minutes = 60 minutes
            double[] distance = new double[] { 10, 20 };
            int[] minute = new int[] { 60, 70 };
            double actual = invoice.CalculateMultipleFare(distance, minute);
            double expected = 440;

            ////Checking if the test case passes
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Test case to check for total no of rides
        /// </summary>
        [Test]
        public void InvoiceReturns_NoOfTrips()
        {
            //// Generating object of class
            InvoiceGenerator invoice = new InvoiceGenerator();

            //// Calculating average fare
            List<Ride> rides = new List<Ride>() { new Ride(10, 60), new Ride(20, 70) };
            InvoiceSummary actual = invoice.EnhancedInvoice(rides);
            InvoiceSummary expected = new InvoiceSummary(2, 440);

            ////Checking if the test case passes
            Assert.AreEqual(expected.mNoOfRides, actual.mNoOfRides); 
        }
        /// <summary>
        /// Test case to return total fare of User with UserID = 'Jayant'
        /// </summary>
        [Test]
        public void InvoiceReturns_RidesOfAParticularUser()
        {
            //// Generating object of class
            InvoiceGenerator invoice = new InvoiceGenerator();

            //// Calculating average fare
            RideRepository user = new RideRepository();
            user.AddRides("Jayant",new List<Ride>(){ new Ride(10, 60), new Ride(20, 70) });
            user.AddRides("Tejas", new List<Ride>() { new Ride(10, 60), new Ride(20, 70) });
            user.AddRides("Jayant", new List<Ride>() { new Ride(10, 60), new Ride(20, 70) });
            List<Ride> ridesOfUser = user.SearchUserRide("Jayant");
            InvoiceSummary actual = invoice.EnhancedInvoice(ridesOfUser);
            InvoiceSummary expected = new InvoiceSummary(2, 880);

            ////Checking if the test case passes
            Assert.AreEqual(expected.mTotalFare, actual.mTotalFare);
        }
    }
}