using CabInvoiceGeneratorApp;

namespace CabInvoiceGeneratorAppTestCase
{
    public class Tests
    {
        private CabInvoiceGenerator cabInvoiceGenerator;
        [SetUp]
        public void Setup()
        {
            this.cabInvoiceGenerator= new CabInvoiceGenerator();
        }

        [Test]
        public void GivenDistanceANdTime_whenAnlaysed_Ssould()
        {
            double totalFare = this.cabInvoiceGenerator.CalculateFare(3.0, 5.0);
            Assert.AreEqual(35.0, totalFare);
        }
        [Test]
        public void GivenDistanceAndTimeFormulaForMultipleRides_WhenProper_Should()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            InvoiceSummary invoiceSummary = this.cabInvoiceGenerator.GetMultipleRidersFare(ride);
            Assert.AreEqual(60.0, invoiceSummary.totalFare);
        }
        //[Test]
        //public void GivenDistanceAndTimeFormulaForMultipleRides_WhenProper_Should()
        //{
        //    Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
        //    double invoiceSummary = this.cabInvoiceGenerator.GetMultipleRidersFare(ride);
        //    Assert.AreEqual(60.0, invoiceSummary);
        //}
    }
}