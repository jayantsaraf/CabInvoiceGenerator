using NUnit.Framework;
using CabInvoiceGen;
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
            double expected = 275;

            ////Checking if the test case passes
            Assert.AreEqual(expected, actual);
        }
    }
}