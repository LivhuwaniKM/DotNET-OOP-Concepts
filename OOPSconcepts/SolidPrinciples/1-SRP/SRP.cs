namespace OOPSconcepts.SolidPrinciples._1_SRP
{
    // Single Responsibility Principle
    public class SRP
    {
        public string Main()
        {
            InvoicePrinter invoiceObject = new();

            return invoiceObject.Print();
        }
    }

    public class Invoice
    {
        public double SubTotal { get; set; }
        public double TaxRate { get; set; }

        public double CalculateTax()
        {
            return this.SubTotal * this.TaxRate / 100;
        }

        public double CalculateTotal()
        {
            return SubTotal + CalculateTax();
        }
    }

    public class InvoicePrinter
    {
        public string Print()
        {
            var invoice = InitializeInvoice();
            var subTotal = invoice.SubTotal;
            var taxRate = invoice.TaxRate;
            var calculateTax = Math.Round(invoice.CalculateTax(), 3);
            var total = invoice.CalculateTotal();

            var calculationsOutput = (
                $"Invoice\n" +
                $"===========================\n" +
                $"Sub Total: {subTotal}\n" +
                $"Tax rate: {taxRate}\n" +
                $"+++++++++++++++++++++++++++\n" +
                $"Calculated Tax: {calculateTax}\n" +
                $"+++++++++++++++++++++++++++\n" +
                $"Total: {total}"
            );
            return calculationsOutput;
        }

        public Invoice InitializeInvoice()
        {
            return new()
            {
                SubTotal = 13000.00,
                TaxRate = 18.15
            };
        }
    }
}
