namespace OOPSconcepts.SolidPrinciples._4_ISP_2
{
    public class Invoice
    {
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTax() =>
            SubTotal * TaxRate / 100;

        public decimal CalulateTotal() =>
            SubTotal + CalculateTax();
    }

    public class InvoiceModifier
    {
        private readonly Invoice _invoice;

        public InvoiceModifier(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void SetSubTotal(decimal amount) =>
            _invoice.SubTotal = amount;

        public void SetTaxRate(decimal amount) =>
            _invoice.TaxRate = amount;

        public Invoice GenerateInvoice()
        {
            return _invoice;
        }
    }

    public class ComplexInvoice
    {
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }
        public decimal SecondTaxRate { get; set; }

        public decimal CalculateTax()
        {
            return (SubTotal * TaxRate / 100) + (SubTotal * SecondTaxRate / 100);
        }

        public decimal CalculateTotal()
        {
            return SubTotal + CalculateTax();
        }
    }

    public class ComplexInvoiceModifier
    {
        private readonly ComplexInvoice _complexInvoice;

        public ComplexInvoiceModifier(ComplexInvoice complexInvoice)
        {
            _complexInvoice = complexInvoice;
        }

        public void SetSubTotal(decimal amount) =>
            _complexInvoice.SubTotal = amount;

        public void SetTaxRate(decimal amount) =>
            _complexInvoice.TaxRate = amount;

        public void SetSecondTaxRate(decimal amount) =>
            _complexInvoice.SecondTaxRate = amount;

        public ComplexInvoice GenerateComplexInvoice()
        {
            return _complexInvoice;
        }
    }

    public interface IInvoicePrinter
    {
        void PrintInvoice(Invoice invoice);
        void PrintComplexInvoice(ComplexInvoice complexInvoice);
    }

    public interface IInvoicePrinterSlip
    {
        void PrintInvoiceSlip(Invoice invoice);
    }

    public class MainMain
    {
        public static void Main()
        {
            Invoice invoice = new()
            {
                SubTotal = 100,
                TaxRate = 18.15M
            };

            Console.WriteLine($"Calculated tax: {invoice.CalculateTax()}");
            Console.WriteLine($"Total: {invoice.CalulateTotal()}");

            Console.ReadLine();
        }
    }
}