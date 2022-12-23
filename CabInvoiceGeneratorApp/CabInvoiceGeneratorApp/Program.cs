namespace CabInvoiceGeneratorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator();
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            cabInvoiceGenerator.MapRidersToUsers("Sourav", ride);
            InvoiceSummary invoiceSummary = cabInvoiceGenerator.GetInvoiceSummary("Sourav");
            Console.WriteLine("Details is : ");
            Console.WriteLine(invoiceSummary.totalFare);
            Console.WriteLine(invoiceSummary.noOfRides);
            Console.WriteLine(invoiceSummary.averageFare);
        }
    }
}
