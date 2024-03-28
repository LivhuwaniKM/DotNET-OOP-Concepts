namespace OOPSconcepts.SolidPrinciples._1_SRP
{
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
            return SubTotal * TaxRate / 100;
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
                $"================================\n" +
                $"Single Responsibility Principle\n" +
                $"================================\n\n" +
                $"Invoice\n" +
                $"--------------------------------\n" +
                $"Sub Total: {subTotal}\n" +
                $"Tax rate: {taxRate}\n" +
                $"--------------------------------\n" +
                $"Calculated Tax: {calculateTax}\n" +
                $"--------------------------------\n" +
                $"Total: {total}"
            );
            return calculationsOutput;
        }

        public Invoice InitializeInvoice()
        {
            return new()
            {
                SubTotal = 23000.00,
                TaxRate = 16.4
            };
        }
    }
}
